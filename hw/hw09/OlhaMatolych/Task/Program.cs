using System;
using GeometryApp;

ShapeGroup group = new();

Triangle t1 = new(
    new Point(0, 0),
    new Point(4, 0),
    new Point(0, 3));

Triangle t2 = new(
    new Point(5, 5),
    new Point(7, 5),
    new Point(6, 8));

Triangle t3 = new(
    new Point(-1, 2),
    new Point(1, 3),
    new Point(0, 5));

group.AddTriangle(t1);
group.AddTriangle(t2);
group.AddTriangle(t3);

Console.WriteLine("All triangles:");
foreach (Triangle triangle in group.GetAll())
{
    triangle.Print();
}

Triangle? closest = group.FindTriangleClosestToOrigin();

Console.WriteLine();
Console.WriteLine("Triangle with vertex closest to (0,0):");
if (closest is not null)
{
    closest.Print();
}
else
{
    Console.WriteLine("No triangles in the group.");
}