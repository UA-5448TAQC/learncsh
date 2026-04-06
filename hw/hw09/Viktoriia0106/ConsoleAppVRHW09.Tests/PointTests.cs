using ConsoleAppVRHW09;

namespace ConsoleAppVRHW09.Tests;

public class PointTests
{
    [Fact]
    public void DistanceTo_ShouldCalculateCorrectDistance()
    {
        // Check the distance between (0,0) and (3,4)
        var p1 = new Point(0, 0);
        var p2 = new Point(3, 4);
        double distance = p1.DistanceTo(p2);
        Assert.Equal(5, distance);
    }

    [Fact]
    public void ToString_ShouldReturnCorrectFormat()
    {
        var p = new Point(1.2, 3.4);
        Assert.Equal("(1.2, 3.4)", p.ToString());
    }
}
