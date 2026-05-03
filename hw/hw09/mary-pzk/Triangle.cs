using System;

namespace HW09
{
    public class Triangle
    {
        private readonly Point vertex1;
        private readonly Point vertex2;
        private readonly Point vertex3;

        public Point Vertex1 => vertex1;
        public Point Vertex2 => vertex2;
        public Point Vertex3 => vertex3;

        public Triangle()
        {
            vertex1 = new Point(0, 0);
            vertex2 = new Point(1, 0);
            vertex3 = new Point(0, 1);
        }

        public Triangle(Point v1, Point v2, Point v3)
        {
            if (AreCollinear(v1, v2, v3))
            {
                throw new ArgumentException("Points must not be collinear.");
            }

            vertex1 = v1;
            vertex2 = v2;
            vertex3 = v3;
        }

        public double Distance(Point a, Point b)
        {
            return a.DistanceTo(b);
        }

        public double Perimeter()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);

            return a + b + c;
        }

        public double Area()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);

            double p = Perimeter() / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public Point ClosestVertexToOrigin()
        {
            Point origin = new Point(0, 0);

            Point closest = vertex1;
            double min = vertex1.DistanceTo(origin);

            double d2 = vertex2.DistanceTo(origin);
            if (d2 < min)
            {
                closest = vertex2;
                min = d2;
            }

            double d3 = vertex3.DistanceTo(origin);
            if (d3 < min)
            {
                closest = vertex3;
            }

            return closest;
        }

        public void Print()
        {
            Console.WriteLine("Triangle:");
            Console.WriteLine($"V1: {vertex1}, V2: {vertex2}, V3: {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter():F2}");
            Console.WriteLine($"Area: {Area():F2}");
            Console.WriteLine($"Closest to (0,0): {ClosestVertexToOrigin()}");
            Console.WriteLine();
        }

        private bool AreCollinear(Point a, Point b, Point c)
        {
            double area = a.X * (b.Y - c.Y)
                        + b.X * (c.Y - a.Y)
                        + c.X * (a.Y - b.Y);

            return area == 0;
        }
    }
}
