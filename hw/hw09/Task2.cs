using System.Drawing;

namespace Task2
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point other)
        {
            X = other.X;
            Y = other.Y;
        }
    }
    public class Triangle //Point
    {
        public Point vertex1;
        public Point vertex2;
        public Point vertex3;

        //public Triangle(vertex1, vertex2, vertex3)
        public Triangle()
        {
            vertex1 = new Point(0, 0);
            vertex2 = new Point(0, 0);
            vertex3 = new Point(0, 0);
        }
        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public Triangle(Point p1, Point p2, Point p3)
        {
            // створюємо КОПІЇ точок → немає зовнішніх посилань
            vertex1 = new Point(p1);
            vertex2 = new Point(p2);
            vertex3 = new Point(p3);
        }
        public double Perimeter() //параметр трикутника
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);

            return a + b + c;
        }

        public double Area()  // Heron's formula
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);

            double s = (a + b + c) / 2; // semi-perimeter

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        // Print шнформацію про трикутник
        public void Print()
        {
            Console.WriteLine("Triangle:");
            Console.WriteLine($"Vertex1: ({vertex1.X}, {vertex1.Y})");
            Console.WriteLine($"Vertex2: ({vertex2.X}, {vertex2.Y})");
            Console.WriteLine($"Vertex3: ({vertex3.X}, {vertex3.Y})");
            Console.WriteLine($"Perymeter: {Perimeter():F2}");
            Console.WriteLine($"Area: {Area():F2}");
        }


        class Program
        {
            static void Main()
            {
                Point p1 = new Point(0, 0);
                Point p2 = new Point(4, 0);
                Point p3 = new Point(0, 3);

                Triangle triangle = new Triangle(p1, p2, p3);

                triangle.Print();
            }
        }
    }
}
