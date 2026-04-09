using System;
using System.Collections.Generic;
using System.Drawing;

namespace Task4
{
    public class Triangle
    {
        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
        }

        public override string ToString()
        {
            return $"({Vertex1.X},{Vertex1.Y}) ({Vertex2.X},{Vertex2.Y}) ({Vertex3.X},{Vertex3.Y})";
        }
    }

    public class ShapeGroup
    {
        private List<Triangle> triangles;

        public ShapeGroup()
        {
            triangles = new List<Triangle>();
        }

        public void AddTriangle(Triangle triangle)
        {
            if (triangle != null)
                triangles.Add(triangle);
        }

        public List<Triangle> GetAll()
        {
            return new List<Triangle>(triangles);
        }

        public Triangle FindTriangleClosestToOrigin()
        {
            if (triangles.Count == 0)
                return null;

            Triangle closestTriangle = null;
            double minDistance = double.MaxValue;

            foreach (var triangle in triangles)
            {
                double d1 = Math.Sqrt(triangle.Vertex1.X * triangle.Vertex1.X +
                                      triangle.Vertex1.Y * triangle.Vertex1.Y);

                double d2 = Math.Sqrt(triangle.Vertex2.X * triangle.Vertex2.X +
                                      triangle.Vertex2.Y * triangle.Vertex2.Y);

                double d3 = Math.Sqrt(triangle.Vertex3.X * triangle.Vertex3.X +
                                      triangle.Vertex3.Y * triangle.Vertex3.Y);

                double triangleMin = Math.Min(d1, Math.Min(d2, d3));

                if (triangleMin < minDistance)
                {
                    minDistance = triangleMin;
                    closestTriangle = triangle;
                }
            }

            return closestTriangle;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeGroup group = new ShapeGroup();

            //  Create 3 triangles
            Triangle t1 = new Triangle(
                new Point(1, 1),
                new Point(2, 2),
                new Point(3, 1)
            );

            Triangle t2 = new Triangle(
                new Point(5, 5),
                new Point(6, 7),
                new Point(7, 5)
            );

            Triangle t3 = new Triangle(
                new Point(0, 2),
                new Point(1, 3),
                new Point(2, 2)
            );

            //  Add them to ShapeGroup
            group.AddTriangle(t1);
            group.AddTriangle(t2);
            group.AddTriangle(t3);

            //  Print all triangles
            Console.WriteLine("All triangles:");
            foreach (var triangle in group.GetAll())
            {
                Console.WriteLine(triangle);
            }

            //  Find triangle with vertex closest to (0,0)
            Triangle result = group.FindTriangleClosestToOrigin();

            //  Print the found triangle
            Console.WriteLine("\nTriangle with vertex closest to (0,0):");
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No triangles");
            }
        }
    }
}