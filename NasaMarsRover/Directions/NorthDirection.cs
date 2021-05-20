namespace NasaMarsRover.Directions
{

    public class NorthDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new WestDirection();
        }

        public override Direction SpinRight()
        {
            return new EastDirection();
        }

        public override void MoveForward(Rover rover)
        {
            rover.SetCoordinateY(rover.GetCoordinateY() + 1);
        }

    }

}
