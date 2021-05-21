using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NasaMarsRover.Commands;

namespace NasaMarsRoverTest
{
    class CommandLookUpTest
    {
        [Test]
        public void ShouldReturnSpinLeftCommandByLeftKey()
        {
            var command = CommandLookup.GetCommand("L");
            Assert.IsInstanceOf(typeof(SpinLeftCommand), command);
        }

        [Test]
        public void ShouldReturnSpinRightCommandByRightKey()
        {
            var command = CommandLookup.GetCommand("R");
            Assert.IsInstanceOf(typeof(SpinRightCommand), command);
        }

        [Test]
        public void ShouldReturnMoveForwardCommandByMoveForwardKey()
        {
            var command = CommandLookup.GetCommand("M");
            Assert.IsInstanceOf(typeof(MoveForwardCommand), command);
        }

        [Test]
        public void ShouldThrowInvalidOperationExceptionForInvalidKey()
        {
            Assert.Throws<InvalidOperationException>(() => CommandLookup.GetCommand("X"));
        }
    }
}
