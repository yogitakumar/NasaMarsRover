using System;
using System.Collections.Generic;
using System.Text;
using NasaMarsRover.Commands;
using NasaMarsRover.Directions;

namespace NasaMarsRover
{
    public class Rover
    {
        private readonly Plateau plateau;
        private int coordinateX;
        private int coordinateY;
        private Direction direction;

        public Rover(Plateau plateau, int coordinateX, int coordinateY, Direction direction)
        {
            if (plateau == null) throw new Exception("The Plateau you create the Rover in cannot be null!");
            if (direction == null) throw new Exception("The Direction the Rover is facing in cannot be null!");

            this.plateau = plateau;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.direction = direction;
            Console.WriteLine("DIRECTION : "+direction);
      
        }

        private Plateau GetPlateau()
        {
            return plateau;
        }

        public int GetCoordinateX()
        {
            return coordinateX;
        }

        public void SetCoordinateX(int coordinateX)
        {
            this.coordinateX = coordinateX;
        }

        public int GetCoordinateY()
        {
            return coordinateY;
        }

        public void SetCoordinateY(int coordinateY)
        {
            this.coordinateY = coordinateY;
        }

        public void SetDirection(Direction direction)
        {
            this.direction = direction;
        }

        public void ExecuteCommandList(List<Command> commands)
        {
            foreach (Command command in commands)
                command.Execute(this);
        }

        public void SpinLeft()
        {
            direction = this.direction.SpinLeft();
        }

        public void SpinRight()
        {
            direction = this.direction.SpinRight();
        }

        public void MoveForward()
        {
            this.direction.MoveForward(this);
            
        }



    }
}
