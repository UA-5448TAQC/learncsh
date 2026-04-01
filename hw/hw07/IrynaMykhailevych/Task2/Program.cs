using System;
using System.Collections.Generic;

namespace hw07_Task2_IrynaMykhailevych
{
    internal class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle("Circle1", 3),
                new Square("Square1", 4),
                new Circle("Circle2", 5),
                new Square("Square2", 2)
            };

            Console.WriteLine("=== Info ===");
            Operator.GetInfo(shapes);

            Console.WriteLine("=== Largest Perimeter ===");
            Operator.GetLargestPerimeter(shapes);

            Console.WriteLine("=== Sorted by Area ===");
            Operator.Sort(shapes);
        }
    }
}
