using System;

public abstract class Shape : IComparable<Shape> //class//
{
    public string Name { get; set; } //property//

    public Shape(string name) //constructor//
    {
        Name = name; //property assignment//
    }
      
    public abstract double Area(); //method//
    public abstract double Perimeter(); //method//

    public int CompareTo(Shape other) //method//
    { 
        if (this.Area() > other.Area()) // Compare the area of the current shape with the area of the other shape
        {
            return 1;
        }
        else if (this.Area() < other.Area()) // If the area of the current shape is less than the area of the other shape
        {
            return -1;
        }
        else // If the areas are equal
        {
            return 0;
        } 
    } //CompareTo()//
} //Shape//
