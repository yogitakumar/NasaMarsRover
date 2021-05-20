namespace NasaMarsRover.Commands
{
    public class MoveForwardCommand : Command
    {
        public override void Execute(Rover rover)
        {
            rover.MoveForward();
        }
    }
}
