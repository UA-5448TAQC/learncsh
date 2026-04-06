using ConsoleAppVRHW09;

namespace ConsoleAppVRHW09.Tests;

public class TriangleTests
{
    [Fact]
    public void Perimeter_ShouldCalculateCorrectValue()
    {
        // (90) Right-angled triangle
        var t = new Triangle(0, 0, 0, 3, 4, 0);
        Assert.Equal(12, t.Perimeter());
    }

    [Fact]
    public void Area_ShouldCalculateCorrectValue()
    {
        var t = new Triangle(0, 0, 0, 3, 4, 0);
        Assert.Equal(6, t.Area());
    }
}
