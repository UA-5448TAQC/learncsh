using System;
using System.Collections.Generic;

public class ShapeGroup
{
    private List<Triangle> triangles = new List<Triangle>();
    public ShapeGroup()
    {
    }
    //Methods
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
        {
            return null;
        }
        Triangle closest = triangles[0];
        Point origin = new Point(0, 0);

        double minDistance = closest.vertex1.DistanceTo(origin); //first vertex distance to origin
        
        if (closest.vertex2.DistanceTo(origin) < minDistance)
        {
            minDistance = closest.vertex2.DistanceTo(origin);            
        }

        if (closest.vertex3.DistanceTo(origin) < minDistance)
        {
            minDistance = closest.vertex3.DistanceTo(origin);            
        }

        foreach (Triangle triangle in triangles) 
        {
            double distance1 = triangle.vertex1.DistanceTo(origin);
            double distance2 = triangle.vertex2.DistanceTo(origin);
            double distance3 = triangle.vertex3.DistanceTo(origin);
            double closestDistance = Math.Min(distance1, Math.Min(distance2, distance3));
            if (closestDistance < minDistance)
            {
                closest = triangle;
                minDistance = closestDistance;           
            }            
        }
        return closest;
    }
}
