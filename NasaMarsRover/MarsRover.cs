using System;

namespace NasaMarsRover
{
    public class MarsRover
    {
        public static void Main()
        {
            var commandList = InputProcessor.BuildInputList();
            Console.WriteLine(commandList); 
        }
    }
}
