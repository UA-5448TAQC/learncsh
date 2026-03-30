using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
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