using GeometryApp;
using Xunit;

namespace GeometryApp.Tests;

public class PointTests
{
    [Fact]
    public void ToString_ReturnsExpectedFormat()
    {
        Point point = new(2.5, -3);

        string result = point.ToString();

        Assert.Equal("(2.5,-3)", result);
    }

    [Fact]
    public void DistanceTo_ReturnsCorrectDistance()
    {
        Point p1 = new(0, 0);
        Point p2 = new(3, 4);

        double result = p1.DistanceTo(p2);

        Assert.Equal(5, result, 10);
    }

    [Fact]
    public void DistanceTo_SamePoint_ReturnsZero()
    {
        Point p1 = new(2, 2);

        double result = p1.DistanceTo(p1);

        Assert.Equal(0, result, 10);
    }

    [Fact]
    public void DistanceTo_NegativeCoordinates_ReturnsCorrectDistance()
    {
        Point p1 = new(-1, -1);
        Point p2 = new(-4, -5);

        double result = p1.DistanceTo(p2);

        Assert.Equal(5, result, 10);
    }
}