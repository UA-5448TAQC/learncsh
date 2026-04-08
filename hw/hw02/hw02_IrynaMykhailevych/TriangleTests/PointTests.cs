using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw09_Task1_IrynaMykhailevych;

namespace hw09_Task1_IrynaMykhailevych.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void DistanceTo_TwoPoints_ReturnsCorrectDistance()
        {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);

            // Act
            double result = p1.DistanceTo(p2);

            // Assert
            Assert.AreEqual(5.0, result, 0.0001);
        }

        [TestMethod]
        public void DistanceTo_SamePoint_ReturnsZero()
        {
            // Arrange
            Point p = new Point(1, 1);

            // Act
            double result = p.DistanceTo(p);

            // Assert
            Assert.AreEqual(0.0, result, 0.0001);
        }

        [TestMethod]
        public void DistanceTo_NegativeCoordinates_ReturnsCorrectDistance()
        {
            // Arrange
            Point p1 = new Point(-1, -1);
            Point p2 = new Point(-4, -5);

            // Act
            double result = p1.DistanceTo(p2);

            // Assert
            Assert.AreEqual(5.0, result, 0.0001);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectFormat()
        {
            // Arrange
            Point p = new Point(2.5, 3.5);

            // Act
            string result = p.ToString();

            // Assert
            Assert.AreEqual("(2.5, 3.5)", result);
        }
    }
}
