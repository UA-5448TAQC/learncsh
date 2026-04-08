using System;
using System.Runtime.InteropServices;

namespace hw09_Task1_IrynaMykhailevych
{
    internal class Program
    {
        static void Main()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4); 
            Point p3 = new Point(6, 0);
            Triangle t1 = new Triangle(p1, p2, p3);

            Point p4 = new Point(1, 1);
            Point p5 = new Point(4, 5);
            Point p6 = new Point(7, 1);
            Triangle t2 = new Triangle(p4, p5, p6);

            Point p7 = new Point(2, 2);
            Point p8 = new Point(5, 6);
            Point p9 = new Point(8, 2);
            Triangle t3 = new Triangle(p7, p8, p9);

            ShapeGroup group = new ShapeGroup();
            group.AddTriangle(t1);
            group.AddTriangle(t2);
            group.AddTriangle(t3);

            Console.WriteLine("All triangles:");

            foreach (Triangle triangle in group.GetAll())
            {
                triangle.Print();
            }

            Console.WriteLine("Closest triangle:");

            Triangle closest = group.FindTriangleClosestToOrigin();

            if (closest != null)
            {
                closest.Print();
            }
        }
    }
}
