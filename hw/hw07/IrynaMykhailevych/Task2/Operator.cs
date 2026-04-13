using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task2_IrynaMykhailevych
{
    internal class Operator
    {
        public static void GetInfo(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }
        }

        public static void GetLargestPerimeter(List<Shape> shapes) 
        {
            Shape largest = shapes[0];
            foreach (var shape in shapes)
            {
                if (shape.Perimeter() > largest.Perimeter())
                {
                    largest = shape;
                }
            }
            Console.WriteLine(largest.Name);
        }

        public static void Sort(List<Shape> shapes)
        {
            shapes.Sort();
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Name);
            }
        }
    }
}
