namespace Task4;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<uint, string> persons = new Dictionary<uint, string>();

        Console.WriteLine("Enter 7 pairs (ID Name (e.g. 1 John):");

        // Введення даних
        for (int i = 0; i < 7; i++)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            uint id = uint.Parse(parts[0]);
            string name = parts[1];

            persons[id] = name;
        }

        // Запит ID
        Console.WriteLine("\nEnter ID to search:");
        uint searchId = uint.Parse(Console.ReadLine());

        // Пошук
        if (persons.ContainsKey(searchId))
        {
            Console.WriteLine($"Name: {persons[searchId]}");
        }
        else
        {
            Console.WriteLine("ID not found.");
        }
    }
}