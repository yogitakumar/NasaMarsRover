namespace NasaMarsRover.Directions
{

    public class NorthDirection : Direction
    {
        public override Direction SpinLeft()
        {
            return new WestDirection();
        }

    }

}
