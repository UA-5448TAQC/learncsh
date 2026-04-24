using NUnit.Framework;
using System;

namespace ConsoleApp1
{
    public class ShapeGroupTests
    {
        [Test]
        public void AddTriangle_AddsTriangleToCollection()
        {
            ShapeGroup group = new ShapeGroup();
            Triangle triangle = new Triangle();

            group.AddTriangle(triangle);

            Assert.That(group.GetAll().Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveTriangle_RemovesTriangleFromCollection()
        {
            ShapeGroup group = new ShapeGroup();
            Triangle triangle = new Triangle();

            group.AddTriangle(triangle);
            bool result = group.RemoveTriangle(triangle);

            Assert.That(result, Is.True);
            Assert.That(group.GetAll().Count, Is.EqualTo(0));
        }

        [Test]
        public void FindTriangleClosestToOrigin_WhenCollectionIsEmpty_ReturnsNull()
        {
            ShapeGroup group = new ShapeGroup();

            Triangle? result = group.FindTriangleClosestToOrigin();

            Assert.That(result, Is.Null);
        }

        [Test]
        public void FindTriangleClosestToOrigin_ReturnsCorrectTriangle()
        {
            ShapeGroup group = new ShapeGroup();

            Triangle farTriangle = new Triangle(
                new Point(10, 10),
                new Point(12, 10),
                new Point(10, 12));

            Triangle nearTriangle = new Triangle(
                new Point(1, 1),
                new Point(3, 1),
                new Point(1, 3));

            group.AddTriangle(farTriangle);
            group.AddTriangle(nearTriangle);

            Triangle? result = group.FindTriangleClosestToOrigin();

            Assert.That(result, Is.SameAs(nearTriangle));
        }
    }
}