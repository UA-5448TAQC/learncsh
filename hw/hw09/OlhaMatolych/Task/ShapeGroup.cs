using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometryApp;

public class ShapeGroup
{
    private readonly List<Triangle> _triangles = new();

    public void AddTriangle(Triangle triangle)
    {
        if (triangle is null)
        {
            throw new ArgumentNullException(nameof(triangle));
        }

        _triangles.Add(triangle);
    }

    public void RemoveTriangle(Triangle triangle)
    {
        if (triangle is null)
        {
            throw new ArgumentNullException(nameof(triangle));
        }

        _triangles.Remove(triangle);
    }

    public IReadOnlyList<Triangle> GetAll() => _triangles.AsReadOnly();

    public Triangle? FindTriangleClosestToOrigin()
    {
        if (_triangles.Count == 0)
        {
            return null;
        }

        return _triangles
            .OrderBy(t => t.ClosestVertexDistanceToOrigin())
            .First();
    }
}