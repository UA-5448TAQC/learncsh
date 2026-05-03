using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW09;

namespace HW09_Test
{
    [TestClass]
    public class Point_Tests
    {
        [TestMethod]
        public void ToString_ShouldReturnPointInCorrectFormat()
        {
            Point point = new Point(3, 4);

            string result = point.ToString();

            Assert.AreEqual("(3,4)", result);
        }

        [TestMethod]
        public void DistanceTo_ShouldReturnCorrectDistance()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);

            double result = point1.DistanceTo(point2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void DistanceTo_SamePoint_ShouldReturnZero()
        {
            Point point1 = new Point(2, 2);
            Point point2 = new Point(2, 2);

            double result = point1.DistanceTo(point2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DistanceTo_NegativeCoordinates_ShouldReturnCorrectDistance()
        {
            Point point1 = new Point(-1, -1);
            Point point2 = new Point(-4, -5);

            double result = point1.DistanceTo(point2);

            Assert.AreEqual(5, result);
        }
    }
}