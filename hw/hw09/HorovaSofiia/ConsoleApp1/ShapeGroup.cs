using System;
using System.Collections.Generic;

namespace ConsoleApp1
    public class ShapeGroup
    {
        private readonly List<Triangle> triangles;

        public ShapeGroup()
        {
            triangles = new List<Triangle>();
        }

        public void AddTriangle(Triangle triangle)
        {
            triangles.Add(triangle);
        }

        public bool RemoveTriangle(Triangle triangle)
        {
            return triangles.Remove(triangle);
        }

        public List<Triangle> GetAll()
        {
            return new List<Triangle>(triangles);
        }

        public Triangle? FindTriangleClosestToOrigin()
        {
            if (triangles.Count == 0)
            {
                return null;
            }

            Triangle closestTriangle = triangles[0];

            foreach (Triangle triangle in triangles)
            {
                if (triangle.GetDistanceOfClosestVertexToOrigin()
                    < closestTriangle.GetDistanceOfClosestVertexToOrigin())
                {
                    closestTriangle = triangle;
                }
            }

            return closestTriangle;
        }
    }
}