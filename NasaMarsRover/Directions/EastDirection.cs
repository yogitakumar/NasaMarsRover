namespace NasaMarsRover.Directions
{
    public class EastDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new NorthDirection();
        }

        public override Direction SpinRight()
        {
            return new SouthDirection();
        }

        public override void MoveForward(Rover rover)
        {
            rover.SetCoordinateX(rover.GetCoordinateX() + 1);
        }

    }
}
