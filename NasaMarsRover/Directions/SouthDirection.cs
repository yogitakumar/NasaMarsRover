namespace NasaMarsRover.Directions
{
    public class SouthDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new EastDirection();
        }
    }
}
