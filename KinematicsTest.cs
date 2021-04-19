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
        [Test]
        public void updatePosition_withNoVelocityAndNoTimeStep_positionIsUnmodified() {
            Kinematics kinematics = new Kinematics();
            double timeStep = 0.0;
            Cartesian expectedPosition = new Cartesian();

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), expectedPosition);
        }

        [Test]
        public void updatePosition_withNoVelocityAndTimeStep_positionIsUnmodified() {
            Kinematics kinematics = new Kinematics();
            double timeStep = 3.3;

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), zeroCartesian);
        }

        [Test]
        public void updatePosition_withVelocityAndNoTimeStep_positionIsUnmodified() {
            Kinematics kinematics = new Kinematics();
            double timeStep = 0.0;
            kinematics.SetVelocity(testVelocity);

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), zeroCartesian);
        }

        [Test]
        public void updatePosition_withVelocityAndTimeStep_positionIsModified() {
            Cartesian expectedPosition = new Cartesian(4.95, 7.5, -14.7);

            Kinematics kinematics = new Kinematics();
            double timeStep = 1.5;
            kinematics.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), expectedPosition);
        }

        [Test]
        public void updatePosition_withInitialPositionVelocityAndTimeStep_positionIsModified() {
            Cartesian expectedPosition = new Cartesian(-10.75, 13.87, -13.951);

            Kinematics kinematics = new Kinematics();
            double timeStep = 1.5;
            kinematics.SetPosition(new Cartesian(-15.7, 6.37, 0.749));
            kinematics.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), expectedPosition);
        }

        [Test]
        public void updatePosition_withNegativeTimeStepAndNoVelocity_positionIsUnmodified() {
            Cartesian expectedPosition = new Cartesian();

            Kinematics kinematics = new Kinematics();
            double timeStep = -3.3;

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), expectedPosition);
        }

        [Test]
        public void updatePosition_withVelocityAndNegativeTimeStep_positionIsModified() {
            Cartesian expectedPosition = new Cartesian(-4.95, -7.5, 14.7);

            Kinematics kinematics = new Kinematics();
            double timeStep = -1.5;
            kinematics.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), expectedPosition);
        }

        [Test]
        public void updatePosition_withInitialPositionVelocityAndNegativeTimeStep_positionIsModified() {
            Cartesian expectedPosition = new Cartesian(-20.65, -1.13, 15.449);

            Kinematics kinematics = new Kinematics();
            double timeStep = -1.5;
            kinematics.SetPosition(new Cartesian(-15.7, 6.37, 0.749));
            kinematics.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

            kinematics.UpdatePosition(timeStep);

            Assert.AreEqual(kinematics.Position(), expectedPosition);
        }

        [Test]
        public void updateVelocity_withNoAccelerationAndNoTimeStep_velocityIsUnmodified() {
            Kinematics kinematics = new Kinematics();
            double timeStep = 0.0;

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), zeroCartesian);
        }

        [Test]
        public void updateVelocity_withNoAccelerationAndTimeStep_velocityIsUnmodified() {
            Kinematics kinematics = new Kinematics();
            double timeStep = 3.3;

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), zeroCartesian);
        }
        [Test]
        public void updateVelocity_withForceAndNoTimeStep_velocityIsUnmodified() {
            Cartesian expectedVelocity = new Cartesian();

            Kinematics kinematics = new Kinematics();
            double timeStep = 0.0;
            kinematics.SetAcceleration(new Cartesian(0.033, 0.05, -0.098));

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), expectedVelocity);
        }

        [Test]
        public void updateVelocity_withAccelerationAndTimeStep_velocityIsModified() {
            Cartesian expectedVelocity = new Cartesian(0.0495, 0.075, -0.147);

            Kinematics kinematics = new Kinematics();
            double timeStep = 1.5;
            kinematics.SetAcceleration(new Cartesian(0.033, 0.05, -0.098));

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), expectedVelocity);
        }

        [Test]
        public void updateVelocity_withInitialVelocityAccelerationAndTimeStep_velocityIsModified() {
            Cartesian expectedVelocity = new Cartesian(-15.6505, 6.445, 0.602);

            Kinematics kinematics = new Kinematics();
            double timeStep = 1.5;
            kinematics.SetVelocity(new Cartesian(-15.7, 6.37, 0.749));
            kinematics.SetAcceleration(new Cartesian(0.033, 0.05, -0.098));

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), expectedVelocity);
        }

        [Test]
        public void updateVelocity_withNegativeTimeStepAndNoAcceleration_velocityIsUnmodified() {
            Kinematics kinematics = new Kinematics();
            double timeStep = -3.3;

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), zeroCartesian);
        }

        [Test]
        public void updateVelocity_withAccelerationAndNegativeTimeStep_velocityIsModified() {
            Cartesian expectedVelocity = new Cartesian(-0.0495, -0.075, 0.147);

            Kinematics kinematics = new Kinematics();
            double timeStep = -1.5;
            kinematics.SetAcceleration(new Cartesian(0.033, 0.05, -0.098));

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), expectedVelocity);
        }
        [Test]
        public void updateVelocity_withInitialVelocityAccelerationAndNegativeTimeStep_velocityIsModified() {
            Cartesian expectedVelocity = new Cartesian(-15.7495, 6.295, 0.896);

            Kinematics kinematics = new Kinematics();
            double timeStep = -1.5;
            kinematics.SetVelocity(new Cartesian(-15.7, 6.37, 0.749));
            kinematics.SetAcceleration(new Cartesian(0.033, 0.05, -0.098));

            kinematics.UpdateVelocity(timeStep);

            Assert.AreEqual(kinematics.Velocity(), expectedVelocity);
        }
    }
}