using System;

public class Square : Shape
{
    public double Side { get; set; }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Perimeter() //method//
    {
        return Side * 4; //method body//
    }
    public override double Area() //method//
    {
        return Side * Side;
    }
}
