using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover.Directions
{
    public static class DirectionLookUp
    {
        private static readonly Dictionary<string, Direction> DirectionDictionary;

        static DirectionLookUp()
        {
            DirectionDictionary = new Dictionary<string, Direction>
            {
                ["N"] = new NorthDirection(),
                ["E"] = new EastDirection(),
                ["S"] = new SouthDirection(),
                ["W"] = new WestDirection()
            };
        }

        public static Direction GetDirection(string directionKey)
        {
            if (DirectionDictionary.ContainsKey(directionKey))
            {
                return DirectionDictionary[directionKey];
            }
            throw new InvalidOperationException("Invalid Direction Key found");
        }

        public static string GetDirectionKey(Direction direction)
        {
            foreach (var item in DirectionDictionary)
            {
                if (item.Value.GetType() == direction.GetType())
                {
                    return item.Key;
                }
            }
            throw new InvalidOperationException("Invalid direction found");
        }
    }
}