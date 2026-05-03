using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW09;
using System;

namespace HW09_Test
{
    [TestClass]
    public class Triangle_Tests
    {
        [TestMethod]
        public void Distance_ShouldReturnCorrectDistance()
        {
            Triangle triangle = new Triangle();

            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);

            double result = triangle.Distance(point1, point2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Perimeter_ShouldReturnCorrectPerimeter()
        {
            Triangle triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4)
            );

            double result = triangle.Perimeter();

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Area_ShouldReturnCorrectArea()
        {
            Triangle triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4)
            );

            double result = triangle.Area();

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Constructor_CollinearPoints_ShouldThrowException()
        {
            try
            {
                Triangle triangle = new Triangle(
                    new Point(0, 0),
                    new Point(1, 1),
                    new Point(2, 2)
                );

                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
            }
        }
    }
}
