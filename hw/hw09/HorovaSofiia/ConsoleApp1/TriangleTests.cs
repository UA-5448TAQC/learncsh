using GeometryHomework.Models;
using NUnit.Framework;
using System;

namespace ConsoleApp1
{
    public class TriangleTests
    {
        [Test]
        public void Distance_ReturnsCorrectDistance()
        {
            Triangle triangle = new Triangle();

            double result = triangle.Distance(new Point(0, 0), new Point(3, 4));

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Perimeter_ReturnsCorrectPerimeter()
        {
            Triangle triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4));

            double result = triangle.Perimeter();

            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Area_ReturnsCorrectArea()
        {
            Triangle triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4));

            double result = triangle.Area();

            Assert.That(result, Is.EqualTo(6).Within(0.000001));
        }

        [Test]
        public void Constructor_WhenPointsAreCollinear_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                new Triangle(
                    new Point(0, 0),
                    new Point(1, 1),
                    new Point(2, 2)));
        }
    }
}