using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover.Commands
{
    public class CommandLookup
    {
        private static readonly Dictionary<string, Command> CommandDictionary;
        static CommandLookup()
        {
            CommandDictionary = new Dictionary<string, Command>
            {
                ["L"] = new SpinLeftCommand(),
                ["R"] = new SpinRightCommand(),
                ["M"] = new MoveForwardCommand(),
            };
        }

        public static Command GetCommand(string commandKey)
        {
            if (CommandDictionary.ContainsKey(commandKey))
            {
               return CommandDictionary[commandKey];
            }
            throw new InvalidOperationException("Invalid Command Key found");
        }
    }
}
