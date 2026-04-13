using System;
using System.Collections;

public class Operator //class/
{
    public static void GetInfO(List<Shape> shapes) //method//
    {
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
        }

    }
         public static void GetLargestPerimeter(List<Shape> shapes) //method//
    {
        Shape maxPerimeterShape = shapes[0]; // Initialize with the first shape in the list
        foreach (Shape shape in shapes) 
        {
            
            if (shape.Perimeter() > maxPerimeterShape.Perimeter()) // Compare the perimeter of the current shape with the maximum perimeter found so far
            {
                maxPerimeterShape = shape;
            }
        }
        Console.WriteLine ($"Shape with largest perimeter: {maxPerimeterShape.Name}, Perimeter: {maxPerimeterShape.Perimeter()}");

    }
    public static void SortByArea(List<Shape> shapes) //method//
    {
        shapes.Sort();
        foreach (Shape shape in shapes) // Iterate through the sorted list of shapes and print their names and areas
        {
            Console.WriteLine($"Sorted shapes: {shape.Name}, Area: {shape.Area()}");
        } //foreach//
    } //SortByArea//
} //Operator//
