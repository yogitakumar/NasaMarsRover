namespace NasaMarsRover.Directions
{
    public class EastDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new NorthDirection();
        }

    }
}
