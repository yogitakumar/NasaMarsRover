namespace NasaMarsRover.Directions
{
    public class WestDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new SouthDirection();
        }

        public override Direction SpinRight()
        {
            return new NorthDirection();
        }

        public override void MoveForward(Rover rover)
        {
            rover.SetCoordinateX(rover.GetCoordinateX() - 1);
        }
    }
}