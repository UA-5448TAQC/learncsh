using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW09;

namespace HW09_Test
{
    [TestClass]
    public class ShapeGroup_Tests
    {
        [TestMethod]
        public void AddTriangle_ShouldAddTriangleToGroup()
        {
            ShapeGroup group = new ShapeGroup();

            Triangle triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4)
            );

            group.AddTriangle(triangle);

            Assert.IsTrue(group.GetAll().Contains(triangle));
        }

        [TestMethod]
        public void RemoveTriangle_ShouldRemoveTriangleFromGroup()
        {
            ShapeGroup group = new ShapeGroup();

            Triangle triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4)
            );

            group.AddTriangle(triangle);
            group.RemoveTriangle(triangle);

            Assert.IsFalse(group.GetAll().Contains(triangle));
        }

        [TestMethod]
        public void FindTriangleClosestToOrigin_ShouldReturnCorrectTriangle()
        {
            ShapeGroup group = new ShapeGroup();

            Triangle farTriangle = new Triangle(
                new Point(10, 10),
                new Point(12, 10),
                new Point(10, 14)
            );

            Triangle closeTriangle = new Triangle(
                new Point(1, 1),
                new Point(4, 1),
                new Point(1, 5)
            );

            group.AddTriangle(farTriangle);
            group.AddTriangle(closeTriangle);

            Triangle result = group.FindTriangleClosestToOrigin();

            Assert.AreEqual(closeTriangle, result);
        }

        [TestMethod]
        public void FindTriangleClosestToOrigin_EmptyGroup_ShouldReturnNull()
        {
            ShapeGroup group = new ShapeGroup();

            Triangle result = group.FindTriangleClosestToOrigin();

            Assert.IsNull(result);
        }
    }
}
