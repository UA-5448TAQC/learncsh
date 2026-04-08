using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw09_Task1_IrynaMykhailevych
{
    public class ShapeGroup
    {
        private List<Triangle> triangles;

        public ShapeGroup()
        {
            triangles = new List<Triangle>();
        }
        
        public void AddTriangle(Triangle triangle)
        {
            triangles.Add(triangle);
        }

        public void RemoveTriangle(Triangle triangle)
        {
            triangles.Remove(triangle);
        }

        public List<Triangle> GetAll()
        {
            return triangles;
        }

        public Triangle FindTriangleClosestToOrigin()
        {
            if (triangles.Count == 0)
                return null;

            Triangle closest = triangles[0];
            double minDistance = DistanceToOrigin(closest);

            foreach (var triangle in triangles)
            {
                double distance = DistanceToOrigin(triangle);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closest = triangle;
                }
            }
            return closest;
        }

        private double DistanceToOrigin(Triangle triangle)
        {
            Point origin = new Point(0, 0);

            double d1 = triangle.Vertex1.DistanceTo(origin);
            double d2 = triangle.Vertex2.DistanceTo(origin);
            double d3 = triangle.Vertex3.DistanceTo(origin);

            return Math.Min(d1, Math.Min(d2, d3));
        }
    }
}
