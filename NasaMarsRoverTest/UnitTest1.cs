using NUnit.Framework;
using System.IO;
using System;
using NasaMarsRover;

namespace NasaMarsRoverTest
{
    public class Tests
    {
        private const string Expected = "Hello World!";

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                NasaMarsRover.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}