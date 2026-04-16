using System;
using System.Collections.Generic;

namespace ShapesTask
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

            Operator.GetInfo(shapes);
            Operator.GetLargestPerimeter(shapes);
            Operator.Sort(shapes);
        }
    }
}