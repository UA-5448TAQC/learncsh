using System;
using System.Collections.Generic;
using System.Drawing;

namespace Task3
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
    }
    public Triangle FindTriangleClosestToOrigin()
        {
            if (triangles.Count == 0)
                return null;

            Triangle closestTriangle = null;
            double minDistance = double.MaxValue;

            foreach (var triangle in triangles)
            {
                double d1 = Math.Sqrt(triangle.Vertex1.X * triangle.Vertex1.X + triangle.Vertex1.Y * triangle.Vertex1.Y);
                double d2 = Math.Sqrt(triangle.Vertex2.X * triangle.Vertex2.X + triangle.Vertex2.Y * triangle.Vertex2.Y);
                double d3 = Math.Sqrt(triangle.Vertex3.X * triangle.Vertex3.X + triangle.Vertex3.Y * triangle.Vertex3.Y);

                double triangleMin = Math.Min(d1, Math.Min(d2, d3));

                if (triangleMin < minDistance)
                {
                    minDistance = triangleMin;
                    closestTriangle = triangle;
                }
            }

            return closestTriangle;
        }
    public class ShapeGroup
    {
        private List<Triangle> triangles;

        public ShapeGroup()
        {
            triangles = new List<Triangle>();
        }

        public void AddTriangle(Triangle triangle) // Додати трикутник (АГРЕГАЦІЯ!)
        {
            if (triangle != null)
                triangles.Add(triangle);
        }

        public void RemoveTriangle(Triangle triangle) // Видалити трикутник
        {
            triangles.Remove(triangle);
        }

        public List<Triangle> GetAll()
        {
            return new List<Triangle>(triangles);
        }

        public Triangle FindTriangleClosestToOrigin()         // Знайти трикутник найближчий до (0,0)
        {
            if (triangles.Count == 0)
                return null;

            Triangle closest = null;
            double minDistance = double.MaxValue;

            foreach (var triangle in triangles)
            {                // центр трикутника

                double centerX = (triangle.Vertex1.X + triangle.Vertex2.X + triangle.Vertex3.X) / 3.0;
                double centerY = (triangle.Vertex1.Y + triangle.Vertex2.Y + triangle.Vertex3.Y) / 3.0;

                double distance = Math.Sqrt(centerX * centerX + centerY * centerY);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closest = triangle;
                }
            }

            return closest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ShapeGroup group = new ShapeGroup();

                Triangle t = new Triangle(
                    new Point(1, 1),
                    new Point(2, 2),
                    new Point(3, 1)
                );

                group.AddTriangle(t);

                var result = group.FindTriangleClosestToOrigin();

                if (result != null)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Empty");
                }
            }
        }
    }
}