using System;
using NUnit.Framework;
using orbital_mechanics;

namespace orbital_mechanics_test {
	[TestFixture]
	public class PlanetTest {
		//update force due to another body
		// //update velocity from force and timestep
		// //update position from velocity and timestep

		// [Test]
		// public void constructor_withNoArgs_initialisesAllMemberVarsToZero() {
		// 	Cartesian zeroCartesian = new Cartesian(0.0, 0.0, 0.0);
		// 	double zeroDouble = 0.0;

		// 	Planet planet = new Planet();

		// 	Assert.AreEqual(zeroCartesian, planet.Position());
		// 	Assert.AreEqual(zeroCartesian, planet.Velocity());
		// 	Assert.AreEqual(zeroCartesian, planet.Force());
		// 	Assert.AreEqual(zeroDouble, planet.Mass());
		// }

		// [Test]
		// public void constructor_withNullPlanetArg_RaisesNullReferenceException() {
		// 	Assert.Throws<NullReferenceException>(() => { Planet planet = new Planet(null); });
		// }

		// [Test]
		// public void constructor_withInitialisedPlanetArg_copiesAllMemberVariables() {
		// 	Cartesian expectedPosition = new Cartesian(1.0, 2.0, 3.0);
		// 	Cartesian expectedVelocity = new Cartesian(2.0, 4.0, 6.0);
		// 	Cartesian expectedForce = new Cartesian(3.0, 6.0, 9.0);
		// 	double expectedMass = 15.0;

		// 	Planet planet = new Planet();
		// 	planet.SetPosition(expectedPosition);
		// 	planet.SetVelocity(expectedVelocity);
		// 	planet.SetForce(expectedForce);
		// 	planet.SetMass(expectedMass);

		// 	Assert.AreEqual(expectedPosition, planet.Position());
		// 	Assert.AreEqual(expectedVelocity, planet.Velocity());
		// 	Assert.AreEqual(expectedForce, planet.Force());
		// 	Assert.AreEqual(expectedMass, planet.Mass());
		// }

		// [Test]
		// public void updatePosition_withNoVelocityAndNoTimeStep_positionIsUnmodified() {
		// 	Planet planet = new Planet();
		// 	double timeStep = 0.0;
		// 	Cartesian expectedPosition = new Cartesian();

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withNoVelocityAndTimeStep_positionIsUnmodified() {
		// 	Cartesian expectedPosition = new Cartesian();

		// 	Planet planet = new Planet();
		// 	double timeStep = 3.3;

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withVelocityAndNoTimeStep_positionIsUnmodified() {
		// 	Cartesian expectedPosition = new Cartesian();

		// 	Planet planet = new Planet();
		// 	double timeStep = 0.0;
		// 	planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withVelocityAndTimeStep_positionIsModified() {
		// 	Cartesian expectedPosition = new Cartesian(4.95, 7.5, -14.7);

		// 	Planet planet = new Planet();
		// 	double timeStep = 1.5;
		// 	planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withInitialPositionVelocityAndTimeStep_positionIsModified() {
		// 	Cartesian expectedPosition = new Cartesian(-10.75, 13.87, -13.951);

		// 	Planet planet = new Planet();
		// 	double timeStep = 1.5;
		// 	planet.SetPosition(new Cartesian(-15.7, 6.37, 0.749));
		// 	planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withNegativeTimeStepAndNoVelocity_positionIsUnmodified() {
		// 	Cartesian expectedPosition = new Cartesian();

		// 	Planet planet = new Planet();
		// 	double timeStep = -3.3;

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withVelocityAndNegativeTimeStep_positionIsModified() {
		// 	Cartesian expectedPosition = new Cartesian(-4.95, -7.5, 14.7);

		// 	Planet planet = new Planet();
		// 	double timeStep = -1.5;
		// 	planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updatePosition_withInitialPositionVelocityAndNegativeTimeStep_positionIsModified() {
		// 	Cartesian expectedPosition = new Cartesian(-20.65, -1.13, 15.449);

		// 	Planet planet = new Planet();
		// 	double timeStep = -1.5;
		// 	planet.SetPosition(new Cartesian(-15.7, 6.37, 0.749));
		// 	planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

		// 	planet.UpdatePosition(timeStep);

		// 	Assert.AreEqual(planet.Position(), expectedPosition);
		// }

		// [Test]
		// public void updateVelocity_withNoForceAndNoTimeStep_velocityIsUnmodified() {
		// 	Planet planet = new Planet();
		// 	double timeStep = 0.0;
		// 	Cartesian expectedVelocity = new Cartesian();
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }

		// [Test]
		// public void updateVelocity_withNoForceAndTimeStep_velocityIsUnmodified() {
		// 	Cartesian expectedVelocity = new Cartesian();

		// 	Planet planet = new Planet();
		// 	double timeStep = 3.3;
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }
		// [Test]
		// public void updateVelocity_withForceAndNoTimeStep_velocityIsUnmodified() {
		// 	Cartesian expectedVelocity = new Cartesian();

		// 	Planet planet = new Planet();
		// 	double timeStep = 0.0;
		// 	planet.SetForce(new Cartesian(3.3, 5.0, -9.8));
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }

		// [Test]
		// public void updateVelocity_withForceAndTimeStep_velocityIsModified() {
		// 	Cartesian expectedVelocity = new Cartesian(0.0495, 0.075, -0.147);

		// 	Planet planet = new Planet();
		// 	double timeStep = 1.5;
		// 	planet.SetForce(new Cartesian(3.3, 5.0, -9.8));
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }

		// [Test]
		// public void updateVelocity_withInitialVelocityForceAndTimeStep_velocityIsModified() {
		// 	Cartesian expectedVelocity = new Cartesian(-15.6505, 6.445, 0.602);

		// 	Planet planet = new Planet();
		// 	double timeStep = 1.5;
		// 	planet.SetVelocity(new Cartesian(-15.7, 6.37, 0.749));
		// 	planet.SetForce(new Cartesian(3.3, 5.0, -9.8));
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }

		// [Test]
		// public void updateVelocity_withNegativeTimeStepAndNoForce_velocityIsUnmodified() {
		// 	Cartesian expectedVelocity = new Cartesian();

		// 	Planet planet = new Planet();
		// 	double timeStep = -3.3;
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }

		// [Test]
		// public void updateVelocity_withForceAndNegativeTimeStep_velocityIsModified() {
		// 	Cartesian expectedVelocity = new Cartesian(-0.0495, -0.075, 0.147);

		// 	Planet planet = new Planet();
		// 	double timeStep = -1.5;
		// 	planet.SetForce(new Cartesian(3.3, 5.0, -9.8));
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }
		// [Test]
		// public void updateVelocity_withInitialVelocityForceAndNegativeTimeStep_velocityIsModified() {
		// 	Cartesian expectedVelocity = new Cartesian(-15.7495, 6.295, 0.896);

		// 	Planet planet = new Planet();
		// 	double timeStep = -1.5;
		// 	planet.SetVelocity(new Cartesian(-15.7, 6.37, 0.749));
		// 	planet.SetForce(new Cartesian(3.3, 5.0, -9.8));
		// 	planet.SetMass(100.0);

		// 	planet.UpdateVelocity(timeStep);

		// 	Assert.AreEqual(planet.Velocity(), expectedVelocity);
		// }

		// [Test]
		// public void updateForce_withNullPlanet_raisesNullReferenceException() {
		// 	Planet planet = new Planet();
		// 	Planet nullPlanet = null;

		// 	Assert.Throws<NullReferenceException>(() => { planet.UpdateForce(nullPlanet); });
		// }
	}
}