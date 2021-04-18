using System;
using NUnit.Framework;
using orbital_mechanics;

namespace orbital_mechanics_test {
    [TestFixture]
    public class OrbitalBodyTest {
        Kinematics zeroKinematics = new Kinematics();
        Cartesian zeroCartesian = new Cartesian();

        Kinematics testKinematics = new Kinematics(
                                        new Cartesian(1.0, 2.0, 3.0),
                                        new Cartesian(2.0, 4.0, 6.0),
                                        new Cartesian(3.0, 6.0, 9.0));

        Cartesian testForce = new Cartesian(4.0, 8.0, 12.0);
        double testMass = 25.0;

        [Test]
        public void constructor_withNoArgs_setsAllToInitalValues() {
            OrbitalBody orbitalBody = new OrbitalBody();

            Assert.AreEqual(orbitalBody.Kinematics(), zeroKinematics);
            Assert.AreEqual(orbitalBody.Force(), zeroCartesian);
            Assert.AreEqual(orbitalBody.Mass(), 0.0);
        }

        [Test]
        public void constructor_withNullArg_throwsNullReferenceException() {
            Assert.Throws<NullReferenceException>(() => { new OrbitalBody(null); });
        }

        [Test]
        public void constructor_withKinematicsArg_copiesKinematicsValues() {
            OrbitalBody originalOrbitalBody = new OrbitalBody();
            originalOrbitalBody.SetKinematics(testKinematics);
            originalOrbitalBody.SetForce(testForce);
            originalOrbitalBody.SetMass(testMass);

            OrbitalBody copiedOrbitalBody = new OrbitalBody(originalOrbitalBody);
            Assert.AreEqual(copiedOrbitalBody.Kinematics(), originalOrbitalBody.Kinematics());
            Assert.AreEqual(copiedOrbitalBody.Force(), originalOrbitalBody.Force());
            Assert.AreEqual(copiedOrbitalBody.Mass(), originalOrbitalBody.Mass());
        }

        [Test]
        public void constructor_withValueArgs_copiesValues() {
            OrbitalBody orbitalBody = new OrbitalBody(testKinematics, testForce, testMass);

            Assert.AreEqual(orbitalBody.Kinematics(), testKinematics);
            Assert.AreEqual(orbitalBody.Force(), testForce);
            Assert.AreEqual(orbitalBody.Mass(), testMass);
        }

        [Test]
        public void equals_withNull_returnsFalse() {
            OrbitalBody kinematics = new OrbitalBody(testKinematics, testForce, testMass);
            OrbitalBody nullKinematics = null;
            Boolean expected = false;

            Boolean actual = kinematics.Equals(nullKinematics);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withOtherClass_returnsFalse() {
            OrbitalBody orbitalBody = new OrbitalBody(testKinematics, testForce, testMass);
            String aString = "";
            Boolean expected = false;

            Boolean actual = orbitalBody.Equals(aString);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withInequalOrbitalMechanics_returnsFalse() {
            double secondMass = 30.0;
            OrbitalBody firstOrbitalBody = new OrbitalBody(testKinematics, testForce, testMass);
            OrbitalBody secondOrbitalBody = new OrbitalBody(testKinematics, testForce, secondMass);
            Boolean expected = false;

            Boolean actual = firstOrbitalBody.Equals(secondOrbitalBody);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withEqualOrbitalBody_returnsTrue() {
            OrbitalBody firstOrbitalBody = new OrbitalBody(testKinematics, testForce, testMass);
            OrbitalBody secondOrbitalBody = new OrbitalBody(testKinematics, testForce, testMass);
            Boolean expected = true;

            Boolean actual = firstOrbitalBody.Equals(secondOrbitalBody);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void equals_withSelf_returnsTrue() {
            OrbitalBody orbitalBody = new OrbitalBody(testKinematics, testForce, testMass);
            Boolean expected = true;

            Boolean actual = orbitalBody.Equals(orbitalBody);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void getHashCode_withTwoEqualObjectsAtInitialValues_returnsSameHash() {
            OrbitalBody firstOrbitalBody = new OrbitalBody();
            OrbitalBody secondOrbitalBody = new OrbitalBody();

            Assert.AreEqual(firstOrbitalBody.GetHashCode(), secondOrbitalBody.GetHashCode());
        }

        [Test]
        public void getHashCode_withTwoEqualObjectsThatHaveBeenModified_returnsSameHash() {
            OrbitalBody firstOrbitalBody = new OrbitalBody(testKinematics, testForce, testMass);
            OrbitalBody secondOrbitalBody = new OrbitalBody(testKinematics, testForce, testMass);

            Assert.AreEqual(firstOrbitalBody.GetHashCode(), secondOrbitalBody.GetHashCode());
        }
    }
}