using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw09_Task1_IrynaMykhailevych;

namespace hw09_Task1_IrynaMykhailevych.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Perimeter_ValidTriangle_ReturnsCorrectPerimeter()
        {
            // Arrange
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));

            // Act
            double result = triangle.Perimeter();

            // Assert
            Assert.AreEqual(12.0, result, 0.0001);
        }

        [TestMethod]
        public void Area_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));

            // Act
            double result = triangle.Area();

            // Assert
            Assert.AreEqual(6.0, result, 0.0001);
        }

        [TestMethod]
        public void Distance_TwoPoints_ReturnsCorrectDistance()
        {
            // Arrange
            Triangle triangle = new Triangle();
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);

            // Act
            double result = triangle.Distance(p1, p2);

            // Assert
            Assert.AreEqual(5.0, result, 0.0001);
        }

        [TestMethod]
        public void InvalidTriangle_AreaReturnsZero()
        {
            // Arrange
            Triangle triangle = new Triangle(new Point(0, 0), new Point(1, 1), new Point(2, 2));

            // Act
            double result = triangle.Area();

            // Assert
            Assert.AreEqual(0.0, result, 0.0001);
        }
    }
}
