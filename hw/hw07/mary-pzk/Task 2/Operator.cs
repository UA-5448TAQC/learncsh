using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07
{
    public class Operator
    {
        public static void GetInfo(List<Shape> shapes)
        {
            Console.WriteLine("All Shapes:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area():F2}, Perimeter: {shape.Perimeter()}");
            }
        }

        public static void GetLargestPerimeter(List<Shape> shapes)
        {
            Console.WriteLine("\nShape with Largest Perimeter:");

            Shape maxShape = shapes[0];

            foreach (var shape in shapes)
            {
                if (shape.Perimeter() > maxShape.Perimeter())
                {
                    maxShape = shape;
                }
            }

            Console.WriteLine(maxShape.Name);
        }

        public static void Sort(List<Shape> shapes)
        {
            Console.WriteLine("\nShapes Sorted by Area:");
            shapes.Sort();

            foreach (var shape in shapes)
                Console.WriteLine(shape.Name);
        }

    }
}
