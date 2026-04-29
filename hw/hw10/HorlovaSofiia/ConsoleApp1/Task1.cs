using System;

namespace ConsoleApp1
{
    internal static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Task 1 — Shapes, LINQ & File Operations");

            List<Shape> shapes = new List<Shape>
            {
                new Circle("AlphaCircle", 2),
                new Square("BetaSquare", 4),
                new Circle("GammaCircle", 6),
                new Square("MiniSquare", 1),
                new Circle("DeltaCircle", 1),
                new Square("LargeSquare", 12)
            };

            IEnumerable<Shape> shapesByArea = shapes
                .Where(shape => shape.Area() >= 10 && shape.Area() <= 100);

            FileHelper.WriteLines(
                "shapes_area_10_100.txt",
                shapesByArea.Select(shape => shape.ToString()));

            IEnumerable<Shape> shapesWithA = shapes
                .Where(shape => shape.Name.Contains('a', StringComparison.OrdinalIgnoreCase));

            FileHelper.WriteLines(
                "shapes_with_a.txt",
                shapesWithA.Select(shape => shape.ToString()));

            shapes.RemoveAll(shape => shape.Perimeter() < 5);

            Console.WriteLine("Resulting shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.WriteLine(new string('-', 60));
        }
    }
}