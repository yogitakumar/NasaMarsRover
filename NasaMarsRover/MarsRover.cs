using System;

namespace NasaMarsRover
{
    public class MarsRover
    {
        public static void Main()
        {

            var commandList = InputProcessor.BuildInputList();

            String[] plateaUpperBound = commandList[0].ToString().Split(" ");

            //Defining Landing Plateau using first instruction.
            Plateau plateau = new Plateau(Int32.Parse(plateaUpperBound[0]), Int32.Parse(plateaUpperBound[1]));
        }
    }
}
