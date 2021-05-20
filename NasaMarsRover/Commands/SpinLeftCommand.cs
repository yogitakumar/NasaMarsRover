namespace NasaMarsRover.Commands
{
    public class SpinLeftCommand : Command
    {
        public override void Execute(Rover rover)
        {
            rover.SpinLeft();
        }
    }
}