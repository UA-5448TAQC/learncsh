using System;
using GeometryApp;
using Xunit;

namespace GeometryApp.Tests;

public class TriangleTests
{
    [Fact]
    public void Distance_ReturnsCorrectValue()
    {
        Triangle triangle = new(
            new Point(0, 0),
            new Point(1, 0),
            new Point(0, 1));

        double result = triangle.Distance(new Point(0, 0), new Point(3, 4));

        Assert.Equal(5, result, 10);
    }

    [Fact]
    public void Perimeter_ReturnsCorrectValue()
    {
        Triangle triangle = new(
            new Point(0, 0),
            new Point(3, 0),
            new Point(0, 4));

        double result = triangle.Perimeter();

        Assert.Equal(12, result, 10);
    }

    [Fact]
    public void Area_ReturnsCorrectValue()
    {
        Triangle triangle = new(
            new Point(0, 0),
            new Point(3, 0),
            new Point(0, 4));

        double result = triangle.Area();

        Assert.Equal(6, result, 10);
    }

    [Fact]
    public void Constructor_CollinearPoints_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Triangle(
                new Point(0, 0),
                new Point(1, 1),
                new Point(2, 2)));
    }
}