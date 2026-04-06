namespace Task3;

using System;
using System.Collections.Generic;

// Інтерфейс
public interface IDeveloper
{
    string Tool { get; set; }

    void Create();
    void Destroy();
}

// Programmer
public class Programmer : IDeveloper, IComparable<IDeveloper>
{
    public string Language { get; set; }
    public string Tool { get; set; }

    public Programmer(string language)
    {
        Language = language;
        Tool = "Computer";
    }

    public void Create()
    {
        Console.WriteLine($"Programmer writes code in {Language}");
    }

    public void Destroy()
    {
        Console.WriteLine($"Programmer deletes code in {Language}");
    }

    public int CompareTo(IDeveloper other)
    {
        return this.Tool.CompareTo(other.Tool);
    }
}

// Builder
public class Builder : IDeveloper, IComparable<IDeveloper>
{
    public string Tool { get; set; }

    public Builder(string tool)
    {
        Tool = tool;
    }

    public void Create()
    {
        Console.WriteLine($"Builder builds using {Tool}");
    }

    public void Destroy()
    {
        Console.WriteLine($"Builder destroys using {Tool}");
    }

    public int CompareTo(IDeveloper other)
    {
        return this.Tool.CompareTo(other.Tool);
    }
}

// Головна програма
class Program
{
    static void Main()
    {
        List<IDeveloper> developers = new List<IDeveloper>()
        {
            new Programmer("C#"),
            new Programmer("Python"),
            new Builder("Hammer"),
            new Builder("Drill")
        };

        Console.WriteLine("Before sorting:\n");

        foreach (var dev in developers)
        {
            dev.Create();
            dev.Destroy();
            Console.WriteLine();
        }

        developers.Sort();

        Console.WriteLine("After sorting:\n");

        foreach (var dev in developers)
        {
            dev.Create();
            dev.Destroy();
            Console.WriteLine();
        }
    }
}