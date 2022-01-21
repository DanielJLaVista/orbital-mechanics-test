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
		// public void updateForce_withNullPlanet_raisesNullReferenceException() {
		// 	Planet planet = new Planet();
		// 	Planet nullPlanet = null;

		// 	Assert.Throws<NullReferenceException>(() => { planet.UpdateForce(nullPlanet); });
		// }
	}
}