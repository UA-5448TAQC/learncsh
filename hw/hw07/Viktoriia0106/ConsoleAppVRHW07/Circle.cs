using System;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Perimeter() //method//
    {
        return 2 * Math.PI * Radius; //method body//
           }
    public override double Area() //method//
    {
        return Math.PI * Radius * Radius;
    }
}
