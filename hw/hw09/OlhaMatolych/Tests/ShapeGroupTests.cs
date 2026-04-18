using GeometryApp;
using Xunit;

namespace GeometryApp.Tests;

public class ShapeGroupTests
{
    [Fact]
    public void AddTriangle_AddsTriangleToCollection()
    {
        ShapeGroup group = new();
        Triangle triangle = new(
            new Point(0, 0),
            new Point(2, 0),
            new Point(0, 2));

        group.AddTriangle(triangle);

        Assert.Single(group.GetAll());
        Assert.Contains(triangle, group.GetAll());
    }

    [Fact]
    public void RemoveTriangle_RemovesTriangleFromCollection()
    {
        ShapeGroup group = new();
        Triangle triangle = new(
            new Point(0, 0),
            new Point(2, 0),
            new Point(0, 2));

        group.AddTriangle(triangle);
        group.RemoveTriangle(triangle);

        Assert.Empty(group.GetAll());
    }

    [Fact]
    public void FindTriangleClosestToOrigin_ReturnsCorrectTriangle()
    {
        ShapeGroup group = new();

        Triangle farTriangle = new(
            new Point(10, 10),
            new Point(12, 10),
            new Point(11, 13));

        Triangle closeTriangle = new(
            new Point(1, 1),
            new Point(2, 1),
            new Point(1, 2));

        group.AddTriangle(farTriangle);
        group.AddTriangle(closeTriangle);

        Triangle? result = group.FindTriangleClosestToOrigin();

        Assert.Same(closeTriangle, result);
    }

    [Fact]
    public void FindTriangleClosestToOrigin_EmptyCollection_ReturnsNull()
    {
        ShapeGroup group = new();

        Triangle? result = group.FindTriangleClosestToOrigin();

        Assert.Null(result);
    }
}