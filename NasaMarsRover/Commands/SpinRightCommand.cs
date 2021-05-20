namespace NasaMarsRover.Commands
{
    public class SpinRightCommand : Command
    {
        public override void Execute(Rover rover)
        {
            rover.SpinRight();
        }
    }
}