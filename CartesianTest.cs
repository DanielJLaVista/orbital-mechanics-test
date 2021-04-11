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
	}
}
