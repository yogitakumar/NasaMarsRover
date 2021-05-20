using System;
using System.Collections.Generic;
using NUnit.Framework;
using NasaMarsRover;
using NasaMarsRover.Commands;

namespace NasaMarsRoverTest
{
    class InputProcessorTest
    {
        [Test]
        public void CheckDataTypeOfNasaMessage()
        {
            List<String> str = InputProcessor.BuildInputList();
            
            Assert.AreEqual(str.GetType(),typeof(List<String>));
            Assert.False(typeof(int) == typeof(List<String>));
        }

        [Test]
        public void CheckCommandInput()
        {
            String commandInputString = "RL";

            List<Command> expectedCommands = new List<Command> { new NasaMarsRover.Commands.SpinLeftCommand(), new NasaMarsRover.Commands.SpinRightCommand() };

            var roverExploreCommand = InputProcessor.ParseCommandInput(commandInputString);

            Assert.False(expectedCommands == roverExploreCommand);

        }
    }
}
