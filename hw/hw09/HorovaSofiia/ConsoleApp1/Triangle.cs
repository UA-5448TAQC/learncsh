using System;

namespace ConsoleApp1
{
    public class Triangle
    {
        private readonly Point vertex1;
        private readonly Point vertex2;
        private readonly Point vertex3;

        public Point Vertex1
        {
            get { return vertex1; }
        }

        public Point Vertex2
        {
            get { return vertex2; }
        }

        public Point Vertex3
        {
            get { return vertex3; }
        }

        public Triangle()
            : this(new Point(0, 0), new Point(1, 0), new Point(0, 1))
        {
        }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            if (AreCollinear(vertex1, vertex2, vertex3))
            {
                throw new ArgumentException("Triangle points must not be collinear.");
            }

            this.vertex1 = new Point(vertex1.X, vertex1.Y);
            this.vertex2 = new Point(vertex2.X, vertex2.Y);
            this.vertex3 = new Point(vertex3.X, vertex3.Y);
        }

        public double Distance(Point firstPoint, Point secondPoint)
        {
            return firstPoint.DistanceTo(secondPoint);
        }

        public double Perimeter()
        {
            return Distance(vertex1, vertex2)
                + Distance(vertex2, vertex3)
                + Distance(vertex3, vertex1);
        }

        public double Area()
        {
            double sideA = Distance(vertex1, vertex2);
            double sideB = Distance(vertex2, vertex3);
            double sideC = Distance(vertex3, vertex1);

            double semiPerimeter = Perimeter() / 2.0;

            return Math.Sqrt(
                semiPerimeter
                * (semiPerimeter - sideA)
                * (semiPerimeter - sideB)
                * (semiPerimeter - sideC));
        }

        public Point GetClosestVertexToOrigin()
        {
            Point origin = new Point(0, 0);

            Point closest = vertex1;

            if (vertex2.DistanceTo(origin) < closest.DistanceTo(origin))
            {
                closest = vertex2;
            }

            if (vertex3.DistanceTo(origin) < closest.DistanceTo(origin))
            {
                closest = vertex3;
            }

            return closest;
        }

        public double GetDistanceOfClosestVertexToOrigin()
        {
            return GetClosestVertexToOrigin().DistanceTo(new Point(0, 0));
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Triangle: {vertex1}, {vertex2}, {vertex3} | "
                + $"Perimeter: {Perimeter():F2} | Area: {Area():F2}";
        }

        private static bool AreCollinear(Point first, Point second, Point third)
        {
            double area = first.X * (second.Y - third.Y)
                + second.X * (third.Y - first.Y)
                + third.X * (first.Y - second.Y);

            return Math.Abs(area) < 0.000001;
        }
    }
}