using NUnit.Framework;

namespace ConsoleApp1
{
    public class PointTests
    {
        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            Point point = new Point(3, 4);

            string result = point.ToString();

            Assert.That(result, Is.EqualTo("(3,4)"));
        }

        [Test]
        public void DistanceTo_WhenSamePoint_ReturnsZero()
        {
            Point first = new Point(2, 2);
            Point second = new Point(2, 2);

            double result = first.DistanceTo(second);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void DistanceTo_WithPositiveCoordinates_ReturnsCorrectDistance()
        {
            Point first = new Point(0, 0);
            Point second = new Point(3, 4);

            double result = first.DistanceTo(second);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DistanceTo_WithNegativeCoordinates_ReturnsCorrectDistance()
        {
            Point first = new Point(-1, -1);
            Point second = new Point(-4, -5);

            double result = first.DistanceTo(second);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}