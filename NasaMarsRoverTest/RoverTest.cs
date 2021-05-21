using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NasaMarsRover;
using NasaMarsRover.Directions;

namespace NasaMarsRoverTest
{
    class RoverTest
    {
        [Test]
        public void CheckRoverCoordinatesFinalResult()
        {
            Rover rover = new Rover(new Plateau(5, 5), 1, 3, new NasaMarsRover.Directions.NorthDirection());
            Assert.AreEqual(rover.GetCoordinateX(), 1);
            Assert.AreEqual(rover.GetCoordinateY(), 3);
            Assert.AreEqual(rover.DisplayLocation(), "1 3 N");
        }
    }

}
