using System;
public class Triangle // class //
{
    public Point vertex1, vertex2, vertex3; // fields-variables //    

    // Default Constructor //
    public Triangle()
    {
        vertex1 = new Point(0, 0);
        vertex2 = new Point(0, 1);
        vertex3 = new Point(1, 0);
    }
    // Parameterized Constructor (6 doubles) //
    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        vertex1 = new Point(x1, y1);
        vertex2 = new Point(x2, y2);
        vertex3 = new Point(x3, y3);
    }

    // Parameterized Constructor (3 Points) //
    public Triangle(Point p1, Point p2, Point p3)
    {
        vertex1 = p1;
        vertex2 = p2;
        vertex3 = p3;
    }

    // Methods //
    public double Distance(Point p1, Point p2)
        {
        return p1.DistanceTo (p2);
    }
    public double Perimeter()
        {
        double side1 = Distance(vertex1, vertex2);
        double side2 = Distance(vertex2, vertex3);
        double side3 = Distance(vertex3, vertex1);

        return side1 + side2 + side3;
    }
    public double Area()
        {
        double side1 = Distance(vertex1, vertex2);
        double side2 = Distance(vertex2, vertex3);
        double side3 = Distance(vertex3, vertex1);
        double s = (side1 + side2 + side3) / 2; // semi-perimeter alternative: double s = Perimeter() / 2;//
        double result = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)); // Heron's formula
        return result; 
    }
    public void Print()
       {
        Console.WriteLine($"Triangle vertices: {vertex1}, {vertex2}, {vertex3}");
        Console.WriteLine($"Perimeter: {Perimeter()}");
        Console.WriteLine($"Area: {Area()}");
    }
}
