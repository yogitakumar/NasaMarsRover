namespace NasaMarsRover.Directions
{
    public class SouthDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new EastDirection();
        }

        public override Direction SpinRight()
        {
            return new WestDirection();
        }

        public override void MoveForward(Rover rover)
        {
            rover.SetCoordinateY(rover.GetCoordinateY() - 1);
        }
    }
}
