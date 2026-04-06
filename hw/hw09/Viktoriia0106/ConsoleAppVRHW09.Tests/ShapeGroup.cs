using ConsoleAppVRHW09;

namespace ConsoleAppVRHW09.Tests;

public class ShapeGroupTests
{
    [Fact]
    public void FindTriangleClosestToOrigin_ShouldReturnCorrectTriangle()
    {
        var group = new ShapeGroup();
        var farTriangle = new Triangle(10, 10, 10, 11, 11, 10);
        var closeTriangle = new Triangle(0, 0, 0, 1, 1, 0); // this close to the origin (0,0,0)

        group.AddTriangle(farTriangle);
        group.AddTriangle(closeTriangle);

        var result = group.FindTriangleClosestToOrigin();
        Assert.Same(closeTriangle, result);
    }
}
