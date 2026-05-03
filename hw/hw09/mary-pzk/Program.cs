using System;

namespace HW09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(
                new Point(1, 1),
                new Point(4, 1),
                new Point(1, 5)
            );

            Triangle t2 = new Triangle(
                new Point(10, 10),
                new Point(12, 10),
                new Point(10, 14)
            );

            Triangle t3 = new Triangle(
                new Point(-1, -1),
                new Point(-3, -1),
                new Point(-1, -4)
            );

            ShapeGroup group = new ShapeGroup();

            group.AddTriangle(t1);
            group.AddTriangle(t2);
            group.AddTriangle(t3);

            Console.WriteLine("All triangles:\n");

            foreach (var t in group.GetAll())
            {
                t.Print();
            }

            Console.WriteLine("Closest triangle to (0,0):\n");

            Triangle closest = group.FindTriangleClosestToOrigin();

            if (closest != null)
            {
                closest.Print();
            }
            else
            {
                Console.WriteLine("No triangles.");
            }
        }
    }
}
