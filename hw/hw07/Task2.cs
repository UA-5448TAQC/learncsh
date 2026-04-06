namespace Task2;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
abstract class Shape : IComparable<Shape>
{
    protected string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Shape(string name)
    {
        this.name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();

    public int CompareTo(Shape other)
    {
        return this.Area().CompareTo(other.Area());
    }
}
class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class Square : Shape
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public Square(string name, double side) : base(name)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return 4 * side;
    }
}
class Operator
{
    public static void GetInfo(List<Shape> shapes)
    {
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Area: {shape.Area():F2}");
            Console.WriteLine($"Perimeter: {shape.Perimeter():F2}");
            Console.WriteLine();
        }
    }

    public static void GetLargestPerimeter(List<Shape> shapes)
    {
        Shape largest = shapes[0];

        foreach (Shape shape in shapes)
        {
            if (shape.Perimeter() > largest.Perimeter())
            {
                largest = shape;
            }
        }

        Console.WriteLine($"Largest perimeter: {largest.Name}");
    }

    public static void Sort(List<Shape> shapes)
    {
        shapes.Sort();

        Console.WriteLine("Sorted by area:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Name);
        }
    }
}
class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle("Circle1", 3),
            new Square("Square1", 4),
            new Circle("Circle2", 5),
            new Square("Square2", 2)
        };

        Operator.GetInfo(shapes);
        Operator.GetLargestPerimeter(shapes);
        Operator.Sort(shapes);
    }
}