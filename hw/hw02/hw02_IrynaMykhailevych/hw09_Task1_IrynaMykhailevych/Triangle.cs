using System;

namespace hw09_Task1_IrynaMykhailevych
{
    public class Triangle
    {
        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }

        public Triangle() : this(new Point(0, 0), new Point(0, 0), new Point(0, 0))
        {
        }

        public Triangle(Point v1, Point v2, Point v3)
        {
            this.Vertex1 = v1;
            this.Vertex2 = v2;
            this.Vertex3 = v3;
        }

        public double Distance(Point a, Point b)
        {
            return a.DistanceTo(b);
        }

        public double Perimeter()
        {
            double side1 = Vertex1.DistanceTo(Vertex2);
            double side2 = Vertex2.DistanceTo(Vertex3);
            double side3 = Vertex3.DistanceTo(Vertex1);

            return side1 + side2 + side3;
        }

        public double Area()
        {
            double side1 = Vertex1.DistanceTo(Vertex2);
            double side2 = Vertex2.DistanceTo(Vertex3);
            double side3 = Vertex3.DistanceTo(Vertex1);
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle vertices: {Vertex1}, {Vertex2}, {Vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Area()}");
        }
    }
}
