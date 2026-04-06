using System;
public class Point
{
    public double x, y;  // fields-variables //    
    public Point(double x, double y) // constructor //
    {
        this.x = x;
        this.y = y;
    } 
    public override string ToString() //method// 
    {
        return $"({x}, {y})";
    }  
    public double DistanceTo(Point other) //method //
    {
        return Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2));
    }
}
