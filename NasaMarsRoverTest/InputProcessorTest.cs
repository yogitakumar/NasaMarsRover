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
        public void ValidateDataTypeForCommandInput()
        {
            List<String> str = InputProcessor.BuildInputList();
            
            Assert.AreEqual(str.GetType(),typeof(List<String>));
            Assert.False(typeof(int) == typeof(List<String>));
        }

        [Test]
        public void CheckCommandInput()
        {
            String commandInputString = "RLRLRLM";

            List<Command> expectedCommands = new List<Command> { new NasaMarsRover.Commands.SpinLeftCommand(), new NasaMarsRover.Commands.SpinRightCommand(),
            new NasaMarsRover.Commands.SpinLeftCommand(), new NasaMarsRover.Commands.SpinRightCommand() ,
            new NasaMarsRover.Commands.SpinLeftCommand(), new NasaMarsRover.Commands.SpinRightCommand() ,new NasaMarsRover.Commands.MoveForwardCommand()};

            var roverExploreCommand = InputProcessor.ParseCommandInput(commandInputString);

            Assert.False(expectedCommands == roverExploreCommand);
        }

        [Test]
        public void ShouldThrowInvalidOperationExceptionForInvalidPlateauCoordinates()
        {
            Assert.Throws<InvalidOperationException>(() => CommandLookup.GetCommand("X"));
        }
    }
}
