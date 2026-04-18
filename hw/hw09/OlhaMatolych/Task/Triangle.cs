using System;

namespace GeometryApp;

public class Triangle
{
    private readonly Point _vertex1;
    private readonly Point _vertex2;
    private readonly Point _vertex3;

    public Point Vertex1 => _vertex1;
    public Point Vertex2 => _vertex2;
    public Point Vertex3 => _vertex3;

    public Triangle()
        : this(new Point(0, 0), new Point(1, 0), new Point(0, 1))
    {
    }

    public Triangle(Point vertex1, Point vertex2, Point vertex3)
    {
        if (AreCollinear(vertex1, vertex2, vertex3))
        {
            throw new ArgumentException("Triangle vertices must not be collinear.");
        }

        _vertex1 = new Point(vertex1.X, vertex1.Y);
        _vertex2 = new Point(vertex2.X, vertex2.Y);
        _vertex3 = new Point(vertex3.X, vertex3.Y);
    }

    public double Distance(Point a, Point b) => a.DistanceTo(b);

    public double Perimeter()
    {
        double ab = Distance(_vertex1, _vertex2);
        double bc = Distance(_vertex2, _vertex3);
        double ca = Distance(_vertex3, _vertex1);

        return ab + bc + ca;
    }

    public double Area()
    {
        double ab = Distance(_vertex1, _vertex2);
        double bc = Distance(_vertex2, _vertex3);
        double ca = Distance(_vertex3, _vertex1);

        double semiPerimeter = (ab + bc + ca) / 2.0;
        return Math.Sqrt(
            semiPerimeter *
            (semiPerimeter - ab) *
            (semiPerimeter - bc) *
            (semiPerimeter - ca));
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public double ClosestVertexDistanceToOrigin()
    {
        Point origin = new(0, 0);

        double d1 = _vertex1.DistanceTo(origin);
        double d2 = _vertex2.DistanceTo(origin);
        double d3 = _vertex3.DistanceTo(origin);

        return Math.Min(d1, Math.Min(d2, d3));
    }

    public override string ToString()
    {
        return $"Triangle: V1={_vertex1}, V2={_vertex2}, V3={_vertex3}, " +
               $"Perimeter={Perimeter():F2}, Area={Area():F2}";
    }

    private static bool AreCollinear(Point a, Point b, Point c)
    {
        double areaTwice = a.X * (b.Y - c.Y) +
                           b.X * (c.Y - a.Y) +
                           c.X * (a.Y - b.Y);

        return Math.Abs(areaTwice) < 1e-10;
    }
}