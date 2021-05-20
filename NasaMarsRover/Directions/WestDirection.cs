namespace NasaMarsRover.Directions
{
    public class WestDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new SouthDirection();
        }

    }
}