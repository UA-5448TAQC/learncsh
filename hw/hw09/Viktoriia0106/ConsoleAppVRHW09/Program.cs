namespace ConsoleAppVRHW09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a triangle with vertices at (0, 4), (0, 8), and (4, 10) 
            Triangle myTriangle = new Triangle(0, 4, 0, 8, 4, 10);

            //Calculate and print the perimeter and area of the triangle - 'Print' method 
            myTriangle.Print();

            //Triangle1 
            Point p1 = new Point(1, 1);
            Point p2 = new Point(4, 1);
            Point p3 = new Point(1, 5);
            Triangle triangle1 = new Triangle(p1, p2, p3);

            //Triangle2
            Point p4 = new Point(0, 0);
            Point p5 = new Point(0, 3);
            Point p6 = new Point(4, 0);
            Triangle triangle2 = new Triangle(p4, p5, p6);

            //Triangle3
            Point p7 = new Point(-1, -1);
            Point p8 = new Point(-1, -4);
            Point p9 = new Point(-5, -1);
            Triangle triangle3 = new Triangle(p7, p8, p9);

            //Create a ShapeGroup and add the three triangles to it
            ShapeGroup group = new ShapeGroup();
            group.AddTriangle(triangle1);
            group.AddTriangle(triangle2);
            group.AddTriangle(triangle3);

            Triangle closest = group.FindTriangleClosestToOrigin();
            closest.Print();
        }
    }
}
