using ConsoleApp1;
using ConsoleApp1.ShapesLinqApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShapesLinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle("Alpha", 2),
                new Square("Box", 4),
                new Circle("Gamma", 4),
                new Square("Delta", 2),
                new Circle("Omega", 1),
                new Square("Max", 6)
            };

            var areaRange = shapes
                .Where(s => s.Area() >= 10 && s.Area() <= 100)
                .Select(s => s.ToString())
                .ToList();

            File.WriteAllLines("shapes_area_10_100.txt", areaRange);

            var withLetterA = shapes
                .Where(s => s.Name.Contains('a', StringComparison.OrdinalIgnoreCase))
                .Select(s => s.ToString())
                .ToList();

            File.WriteAllLines("shapes_with_a.txt", withLetterA);

            shapes.RemoveAll(s => s.Perimeter() < 5);

            Console.WriteLine("Resulting list:");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}