using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover
{
    public class Plateau
    {
        private const int lowerBoundCoordinateX = 0;
        private const int lowerBoundCoordinateY = 0;
        private readonly int upperBoundCoordinateX;
        private readonly int upperBoundCoordinateY;

        public Plateau(int upperBoundCoordinateX, int upperBoundCoordinateY)
        {
            this.upperBoundCoordinateX = upperBoundCoordinateX;
            this.upperBoundCoordinateY = upperBoundCoordinateY;
        }
        public int GetLowerBoundCoordinateX()
        {
            return lowerBoundCoordinateX;
        }
        public int GetLowerBoundCoordinateY()
        {
            return lowerBoundCoordinateY;
        }
        public int GetUpperBoundCoordinateX()
        {
            return upperBoundCoordinateX;
        }

        public int GetUpperBoundCoordinateY()
        {
            return upperBoundCoordinateY;
        }
    }
}