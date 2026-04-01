namespace Task2;

using System;
using System.Collections.Generic;

// Інтерфейс
public interface IFlyable
{
    void Fly();
}

// Клас Bird
public class Bird : IFlyable
{
    public string Name { get; set; }
    public bool CanFly { get; set; }

    public Bird(string name, bool canFly)
    {
        Name = name;
        CanFly = canFly;
    }

    public void Fly()
    {
        if (CanFly)
            Console.WriteLine($"Bird {Name} is flying.");
        else
            Console.WriteLine($"Bird {Name} cannot fly.");
    }
}

// Клас Plane
public class Plane : IFlyable
{
    public string Mark { get; set; }
    public bool HighFly { get; set; }

    public Plane(string mark, bool highFly)
    {
        Mark = mark;
        HighFly = highFly;
    }

    public void Fly()
    {
        if (HighFly)
            Console.WriteLine($"Plane {Mark} is flying high.");
        else
            Console.WriteLine($"Plane {Mark} is flying at low altitude.");
    }
}

// Головна програма
class Program
{
    static void Main()
    {
        List<IFlyable> flyingObjects = new List<IFlyable>
        {
            new Bird("Eagle", true),
            new Bird("Penguin", false),
            new Plane("Boeing 747", true),
            new Plane("Cessna", false)
        };

        foreach (var obj in flyingObjects)
        {
            obj.Fly();
        }
    }
}