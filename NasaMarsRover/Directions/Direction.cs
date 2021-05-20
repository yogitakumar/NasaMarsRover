using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover.Directions
{
    public abstract class Direction
    {
        public abstract Direction SpinLeft();

        public abstract Direction SpinRight();

        public abstract void MoveForward(Rover rover);
    }
}
