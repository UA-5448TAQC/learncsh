using System;

namespace ConsoleApp1
{
    internal static class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Task 4 — JSON Serialization");

            ShapeDto shape = new ShapeDto
            {
                Type = "Circle",
                Name = "JsonCircle",
                Size = 5
            };

            FileHelper.SerializeToJson("shape.json", shape);

            ShapeDto? restoredShape = FileHelper.DeserializeFromJson<ShapeDto>("shape.json");

            if (restoredShape is not null)
            {
                Console.WriteLine("Deserialized object:");
                Console.WriteLine($"Type: {restoredShape.Type}");
                Console.WriteLine($"Name: {restoredShape.Name}");
                Console.WriteLine($"Size: {restoredShape.Size}");
            }
            else
            {
                Console.WriteLine("Deserialization failed.");
            }

            Console.WriteLine(new string('-', 60));
        }
    }
}