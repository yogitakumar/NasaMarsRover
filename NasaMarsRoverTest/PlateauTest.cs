using NUnit.Framework;
using NasaMarsRover;


namespace NasaMarsRoverTest
{
    class PlateauTest
    {
        [Test]
        public void CheckPlateauCoordinates()
        {
            Plateau plateau = new Plateau(5,5);

            Assert.AreEqual(plateau.GetLowerBoundCoordinateX(), 0);
            Assert.AreEqual(plateau.GetLowerBoundCoordinateY(), 0);
            Assert.AreEqual(plateau.GetUpperBoundCoordinateX(), 5);
            Assert.AreEqual(plateau.GetUpperBoundCoordinateX(), 5);
        }
    }

    [TestFixture]
    public class PlateauIsValidPoint
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 3)]
        [TestCase(7, 8)]
        public void WhenPointIsWithinPlateauBoundaryReturnsTrue(int attemptedCoordinateX, int attemptedCoordinateY)
        {
            var plateau = new Plateau(attemptedCoordinateX, attemptedCoordinateY);

            var isValidPoint = (attemptedCoordinateX <= plateau.GetUpperBoundCoordinateX() && attemptedCoordinateY <= plateau.GetUpperBoundCoordinateY());
            Assert.That(isValidPoint);
        }

    }
}
