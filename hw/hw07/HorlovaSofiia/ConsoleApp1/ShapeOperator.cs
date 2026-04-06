using System;

namespace ConsoleApp1
{
    internal static class ShapeOperator
    {
        public static void GetInfo(List<Shape> shapes)
        {
            Console.WriteLine("Shapes info:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(
                    $"Name: {shape.Name}, Area: {shape.Area():F2}, Perimeter: {shape.Perimeter():F2}");
            }

            Console.WriteLine();
        }

        public static void GetLargestPerimeter(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                Console.WriteLine("No shapes found.");
                Console.WriteLine();
                return;
            }

            Shape largest = shapes[0];

            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > largest.Perimeter())
                {
                    largest = shape;
                }
            }

            Console.WriteLine($"Shape with largest perimeter: {largest.Name}");
            Console.WriteLine();
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