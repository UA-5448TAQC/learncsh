using System;
using System.Collections.Generic;

namespace ShapesTask
{
    public static class Operator
    {
        public static void GetInfo(List<Shape> shapes)
        {
            Console.WriteLine("Shapes info:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Name: " + shape.Name);
                Console.WriteLine("Area: " + shape.Area());
                Console.WriteLine("Perimeter: " + shape.Perimeter());
                Console.WriteLine();
            }
        }

        public static void GetLargestPerimeter(List<Shape> shapes)
        {
            if (shapes.Count == 0)
                return;

            Shape maxShape = shapes[0];

            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > maxShape.Perimeter())
                {
                    maxShape = shape;
                }
            }

            Console.WriteLine("Shape with largest perimeter: " + maxShape.Name);
        }

        public static void Sort(List<Shape> shapes)
        {
            shapes.Sort();

            Console.WriteLine("Shapes sorted by area:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Name);
            }
        }
    }
}