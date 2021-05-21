using System;
using System.Collections.Generic;
using NasaMarsRover.Commands;


namespace NasaMarsRover
{
    public class MarsRover
    {
        public static void Main()
        {
            // Reading Input String
            var commandList = InputProcessor.BuildInputList();

            String[] plateauUpperBound = commandList[0].ToString().Split(" ");

            // Defining Landing Plateau using first instruction.
            Plateau plateau = new Plateau(Int32.Parse(plateauUpperBound[0]), Int32.Parse(plateauUpperBound[1]));

            // Creating sublist with Rover initial position and commands
            List<string> roverInput = commandList.GetRange(1, commandList.Count - 1);

            //Execute CommandList 
            for (int commandIndex = 0; commandIndex < roverInput.Count; commandIndex += 2)
            {
                Rover rover = InputProcessor.ParsePositionInput(roverInput[commandIndex], plateau);
                List<Command> commands = InputProcessor.ParseCommandInput(roverInput[commandIndex + 1]);
                rover.ExecuteCommandList(commands);
                Console.WriteLine(rover.DisplayLocation());
            }
        }

    }
}