using System;
using NUnit.Framework;
using orbital_mechanics;

namespace orbital_mechanics_test {
    [TestFixture]
    public class KinematicsTest {
        Cartesian zeroCartesian = new Cartesian();
        Cartesian testPosition = new Cartesian(1.0, 2.0, 3.0);
        Cartesian testVelocity = new Cartesian(2.0, 4.0, 6.0);
        Cartesian testAcceleration = new Cartesian(3.0, 6.0, 9.0);

        [Test]
        public void constructor_withNoArgs_setsAllToInitalValues() {
            Kinematics kinematics = new Kinematics();

            Assert.AreEqual(kinematics.Position(), zeroCartesian);
            Assert.AreEqual(kinematics.Velocity(), zeroCartesian);
            Assert.AreEqual(kinematics.Acceleration(), zeroCartesian);
        }

        [Test]
        public void constructor_withNullArg_throwsNullReferenceException() {
            Assert.Throws<NullReferenceException>(() => { new Kinematics(null); });
        }

        [Test]
        public void constructor_withKinematicsArg_copiesKinematicsValues() {
            Kinematics originalKinematics = new Kinematics();
            originalKinematics.SetPosition(testPosition);
            originalKinematics.SetVelocity(testVelocity);
            originalKinematics.SetAcceleration(testAcceleration);

            Kinematics copiedKinematics = new Kinematics(originalKinematics);
            Assert.AreEqual(copiedKinematics.Position(), originalKinematics.Position());
            Assert.AreEqual(copiedKinematics.Velocity(), originalKinematics.Velocity());
            Assert.AreEqual(copiedKinematics.Acceleration(), originalKinematics.Acceleration());
        }

        [Test]
        public void constructor_withCartesianArgs_copiesCartesianValues() {
            Kinematics kinematics = new Kinematics(testPosition, testVelocity, testAcceleration);

            Assert.AreEqual(kinematics.Position(), testPosition);
            Assert.AreEqual(kinematics.Velocity(), testVelocity);
            Assert.AreEqual(kinematics.Acceleration(), testAcceleration);
        }

        [Test]
        public void equals_withNull_returnsFalse() {
            Kinematics kinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            Kinematics nullKinematics = null;
            Boolean expected = false;

            Boolean actual = kinematics.Equals(nullKinematics);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withOtherClass_returnsFalse() {
            Kinematics kinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            String aString = "";
            Boolean expected = false;

            Boolean actual = kinematics.Equals(aString);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withInequalKinematics_returnsFalse() {
            Cartesian secondPosition = new Cartesian(-1.0, -2.0, -3.0);
            Cartesian secondVelocity = new Cartesian(-2.0, -4.0, -6.0);
            Cartesian secondAcceleration = new Cartesian(-3.0, -6.0, -9.0);
            Kinematics firstKinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            Kinematics secondKinematics = new Kinematics(secondPosition, secondVelocity, secondAcceleration);
            Boolean expected = false;

            Boolean actual = firstKinematics.Equals(secondKinematics);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withEqualKinematics_returnsTrue() {
            Kinematics firstKinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            Kinematics secondKinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            Boolean expected = true;

            Boolean actual = firstKinematics.Equals(secondKinematics);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withSelf_returnsTrue() {
            Kinematics kinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            Boolean expected = true;

            Boolean actual = kinematics.Equals(kinematics);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getHashCode_withTwoEqualObjectsAtInitialValues_returnsSameHash() {
            Kinematics firstKinematics = new Kinematics();
            Kinematics secondKinematics = new Kinematics();

            Assert.AreEqual(firstKinematics.GetHashCode(), secondKinematics.GetHashCode());
        }

        [Test]
        public void getHashCode_withTwoEqualObjectsThatHaveBeenModified_returnsSameHash() {
            Kinematics firstKinematics = new Kinematics(testPosition, testVelocity, testAcceleration);
            Kinematics secondKinematics = new Kinematics(testPosition, testVelocity, testAcceleration);

            Assert.AreEqual(firstKinematics.GetHashCode(), secondKinematics.GetHashCode());
        }
    }
}