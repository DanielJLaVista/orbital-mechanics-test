using System;
using NUnit.Framework;
using orbital_mechanics;

namespace orbital_mechanics_test {
	[TestFixture]
	public class CartesianTest {
#warning Messages for test failures
		[Test]
		public void constructor_withNoArgs_setsAllToZero() {
			Cartesian cartesian = new Cartesian();

			Assert.AreEqual(cartesian.X(), 0.0);
			Assert.AreEqual(cartesian.Y(), 0.0);
			Assert.AreEqual(cartesian.Z(), 0.0);
		}

		[Test]
		public void constructor_withNullArg_throwsNullReferenceException() {
			Assert.Throws<NullReferenceException>(() => { new Cartesian(null); });
		}

		[Test]
		public void constructor_withCartesianArg_copiesCartesianValues() {
			Cartesian originalCartesian = new Cartesian();
			originalCartesian.SetX(-1.0);
			originalCartesian.SetY(15.0);
			originalCartesian.SetZ(0.356);

			Cartesian copiedCartesian = new Cartesian(originalCartesian);
			Assert.AreEqual(copiedCartesian.X(), originalCartesian.X());
			Assert.AreEqual(copiedCartesian.Y(), originalCartesian.Y());
			Assert.AreEqual(copiedCartesian.Z(), originalCartesian.Z());
		}

		[Test]
		public void constructor_withDoubleArgs_copiesDoubleValues() {
			double xVal = -1.0;
			double yVal = 15.0;
			double zVal = 0.356;

			Cartesian cartesian = new Cartesian(xVal, yVal, zVal);
			Assert.AreEqual(cartesian.X(), xVal);
			Assert.AreEqual(cartesian.Y(), yVal);
			Assert.AreEqual(cartesian.Z(), zVal);
		}

		[Test]
		public void equals_withNull_returnsFalse() {
			Cartesian cartesian = new Cartesian(1.0, 2.0, 3.0);
			Cartesian nullCartesian = null;
			Boolean expected = false;

			Boolean actual = cartesian.Equals(nullCartesian);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void equals_withOtherClass_returnsFalse() {
			Cartesian cartesian = new Cartesian(1.0, 2.0, 3.0);
			String aString = "";
			Boolean expected = false;

			Boolean actual = cartesian.Equals(aString);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void equals_withInequalCartesian_returnsFalse() {
			Cartesian firstCartesian = new Cartesian(1.0, 2.0, 3.0);
			Cartesian secondCartesian = new Cartesian(2.0, 4.0, 6.0);
			Boolean expected = false;

			Boolean actual = firstCartesian.Equals(secondCartesian);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void equals_withEqualCartesian_returnsTrue() {
			Cartesian firstCartesian = new Cartesian(1.0, 2.0, 3.0);
			Cartesian secondCartesian = new Cartesian(1.0, 2.0, 3.0);
			Boolean expected = true;

			Boolean actual = firstCartesian.Equals(secondCartesian);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void equals_withSelf_returnsTrue() {
			Cartesian cartesian = new Cartesian(1.0, 2.0, 3.0);
			Boolean expected = true;

			Boolean actual = cartesian.Equals(cartesian);

			Assert.AreEqual(expected, actual);
		}
	}
}
