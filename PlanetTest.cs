using System;
using NUnit.Framework;
using orbital_mechanics;

namespace orbital_mechanics_test {
	[TestFixture]
	public class PlanetTest {
		//update force due to another body
		//update velocity from force and timestep
		//update position from velocity and timestep
		//set velocity
		//position with nothing else
		//position with existing position
		//position with existing velocity

		[Test]
		public void updatePosition_withNoVelocityAndNoTimeStep_positionIsUnmodified() {
			Planet planet = new Planet();
			double timeStep = 0.0;
			Cartesian expectedPosition = new Cartesian();

			planet.UpdatePosition(timeStep);

			Assert.AreEqual(planet.Position(), expectedPosition);
		}

		[Test]
		public void updatePosition_withTimeStepAndNoVelocity_positionIsUnmodified() {
			Cartesian expectedPosition = new Cartesian();

			Planet planet = new Planet();
			double timeStep = 3.3;

			planet.UpdatePosition(timeStep);

			Assert.AreEqual(planet.Position(), expectedPosition);
		}

		[Test]
		public void updatePosition_withVelocityAndNoTimeStep_positionIsUnmodified() {
			Cartesian expectedPosition = new Cartesian();

			Planet planet = new Planet();
			double timeStep = 0.0;
			planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

			planet.UpdatePosition(timeStep);

			Assert.AreEqual(planet.Position(), expectedPosition);
		}

		[Test]
		public void updatePosition_withVelocityAndTimeStep_positionIsUnmodified() {
			Cartesian expectedPosition = new Cartesian(4.95, 7.5, -14.7);

			Planet planet = new Planet();
			double timeStep = 1.5;
			planet.SetVelocity(new Cartesian(3.3, 5.0, -9.8));

			planet.UpdatePosition(timeStep);

			Assert.AreEqual(planet.Position(), expectedPosition);
		}



	}
}