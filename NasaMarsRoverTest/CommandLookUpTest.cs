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
        public void ShouldReturnSpinLeftCommandByRightKey()
        {
            var command = CommandLookup.GetCommand("L");
            Assert.IsInstanceOf(typeof(SpinLeftCommand), command);
        }
    }
}
