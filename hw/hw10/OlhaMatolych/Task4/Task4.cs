using System;
using System.IO;
using System.Text.Json;

namespace Task4;

internal class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Bob",
            Marks = new() { 90, 85, 100 }
        };

        string json = JsonSerializer.Serialize(student, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("student.json", json);

        string jsonFromFile = File.ReadAllText("student.json");

        Student restored = JsonSerializer.Deserialize<Student>(jsonFromFile);

        Console.WriteLine("Restored object:");
        Console.WriteLine($"Name: {restored.Name}");
        Console.WriteLine("Marks: " + string.Join(", ", restored.Marks));
    }
}