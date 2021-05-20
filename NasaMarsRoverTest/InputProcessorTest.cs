using System;
using System.Collections.Generic;
using NUnit.Framework;
using NasaMarsRover;


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
    }
}
