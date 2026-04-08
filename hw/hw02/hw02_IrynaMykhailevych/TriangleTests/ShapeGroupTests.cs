using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw09_Task1_IrynaMykhailevych;

namespace hw09_Task1_IrynaMykhailevych.Tests
{
    [TestClass]
    public class ShapeGroupTests
    {
        [TestMethod]
        public void AddTriangle_ValidTriangle_AddsToGroup()
        {
            // Arrange
            ShapeGroup group = new ShapeGroup();
            Triangle triangle = new Triangle();

            // Act
            group.AddTriangle(triangle);

            // Assert
            Assert.AreEqual(1, group.GetAll().Count);
        }

        [TestMethod]
        public void RemoveTriangle_ExistingTriangle_RemovesFromGroup()
        {
            // Arrange
            ShapeGroup group = new ShapeGroup();
            Triangle triangle = new Triangle();

            group.AddTriangle(triangle);

            // Act
            group.RemoveTriangle(triangle);

            // Assert
            Assert.IsEmpty(group.GetAll());
        }

        [TestMethod]
        public void FindTriangleClosestToOrigin_TrianglesExist_ReturnsClosestTriangle()
        {
            // Arrange
            ShapeGroup group = new ShapeGroup();

            Triangle farTriangle = new Triangle(new Point(10, 10), new Point(11, 10), new Point(10, 11));
            Triangle closeTriangle = new Triangle(new Point(1, 1), new Point(2, 1), new Point(1, 2));

            group.AddTriangle(farTriangle);
            group.AddTriangle(closeTriangle);

            // Act
            Triangle result = group.FindTriangleClosestToOrigin();

            // Assert
            Assert.AreEqual(closeTriangle, result);
        }

        [TestMethod]
        public void FindTriangleClosestToOrigin_EmptyGroup_ReturnsNull()
        {
            // Arrange
            ShapeGroup group = new ShapeGroup();

            // Act
            Triangle result = group.FindTriangleClosestToOrigin();

            // Assert
            Assert.IsNull(result);
        }
    }
}
