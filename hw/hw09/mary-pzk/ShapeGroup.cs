using System.Collections.Generic;

namespace HW09
{
    public class ShapeGroup
    {
        private readonly List<Triangle> triangles = new List<Triangle>();

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

            Point origin = new Point(0, 0);

            Triangle closest = triangles[0];
            double min = triangles[0].ClosestVertexToOrigin().DistanceTo(origin);

            foreach (var t in triangles)
            {
                double d = t.ClosestVertexToOrigin().DistanceTo(origin);

                if (d < min)
                {
                    min = d;
                    closest = t;
                }
            }

            return closest;
        }
    }
}
