using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Operator
    {
        public static void GetInfo(List<Shape> shapes)
        {
            Console.WriteLine("=== Shapes Info ===");

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area():F2}, Perimeter: {shape.Perimeter():F2}");
            }
        }

        public static void GetLargestPerimeter(List<Shape> shapes)
        {
            var largest = shapes.OrderByDescending(s => s.Perimeter()).FirstOrDefault();

            if (largest != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape with largest perimeter: {largest.Name}");
            }
        }

        public static void Sort(List<Shape> shapes)
        {
            shapes.Sort();

            Console.WriteLine();
            Console.WriteLine("=== Shapes Sorted by Area ===");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Name);
            }
        }
    }
}