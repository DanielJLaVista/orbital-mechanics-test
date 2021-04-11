using System;
using NUnit.Framework;
using orbital_mechanics;

namespace orbital_mechanics_test {
	[TestFixture]
	public class CartesianTest {
		[Test]
		public void constructor_withNoArgs_setsAllToZero() {
			Cartesian cartesian = new Cartesian();

			Assert.That(cartesian.X(), Is.EqualTo(0.0));
			Assert.That(cartesian.Y(), Is.EqualTo(0.0));
			Assert.That(cartesian.Z(), Is.EqualTo(0.0));
		}

		[Test]
		public void constructor_withNullArg_throwsNullReferenceException() {
			Assert.Throws<NullReferenceException>(() => { new Cartesian(null); });
		}

		[Test]
		public void constructor_withCartesianArg_copiesCartesianValues() {
			Cartesian originalCartesian = new Cartesian();
			originalCartesian.setX(-1.0);
			originalCartesian.setY(15.0);
			originalCartesian.setZ(0.356);

			Cartesian copiedCartesian = new Cartesian(originalCartesian);
			Assert.That(copiedCartesian.X(), Is.EqualTo(originalCartesian.X()));
			Assert.That(copiedCartesian.Y(), Is.EqualTo(originalCartesian.Y()));
			Assert.That(copiedCartesian.Z(), Is.EqualTo(originalCartesian.Z()));
		}

		[Test]
		public void constructor_withDoubleArgs_copiesDoubleValues() {
			double xVal = -1.0;
			double yVal = 15.0;
			double zVal = 0.356;

			Cartesian cartesian = new Cartesian(xVal, yVal, zVal);
			Assert.That(cartesian.X(), Is.EqualTo(xVal));
			Assert.That(cartesian.Y(), Is.EqualTo(yVal));
			Assert.That(cartesian.Z(), Is.EqualTo(zVal));
		}

	}
}
