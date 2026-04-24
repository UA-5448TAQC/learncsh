using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(
                new Point(0, 0),
                new Point(3, 0),
                new Point(0, 4));

            Triangle triangle2 = new Triangle(
                new Point(5, 5),
                new Point(8, 5),
                new Point(5, 9));

            Triangle triangle3 = new Triangle(
                new Point(-2, -1),
                new Point(-4, 3),
                new Point(1, 2));

            ShapeGroup group = new ShapeGroup();

            group.AddTriangle(triangle1);
            group.AddTriangle(triangle2);
            group.AddTriangle(triangle3);

            Console.WriteLine("All triangles:");
            foreach (Triangle triangle in group.GetAll())
            {
                triangle.Print();
                Console.WriteLine();
            }

            Triangle? closestTriangle = group.FindTriangleClosestToOrigin();

            Console.WriteLine("Triangle with vertex closest to origin:");
            if (closestTriangle is not null)
            {
                closestTriangle.Print();
            }
            else
            {
                Console.WriteLine("Shape group is empty.");
            }

            Console.ReadKey();
        }
    }
}