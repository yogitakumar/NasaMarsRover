using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover
{
    public class InputProcessor
    {
        public static List<String> BuildInputList()
        {
            List<String> cmdList = new List<String>();
            cmdList.Add("5 5");
            cmdList.Add("1 2 N");
            cmdList.Add("LMLMLMLMM");
            cmdList.Add("3 3 E");
            cmdList.Add("MMRMMRMRRM");

            for(int cmd=0;cmd<cmdList.Count;cmd++)
            {
                Console.WriteLine(cmdList[cmd]);
            }
           return cmdList;
        }
    }
}
