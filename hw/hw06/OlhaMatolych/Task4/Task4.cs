using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            Console.WriteLine("Enter 7 pairs: ID Name");

            for (int i = 0; i < 7; i++)
            {
                string? line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine("Empty input. Try again.");
                    i--;
                    continue;
                }

                string[] input = line.Split();

                if (input.Length < 2)
                {
                    Console.WriteLine("Please enter ID and Name.");
                    i--;
                    continue;
                }

                if (!uint.TryParse(input[0], out uint id))
                {
                    Console.WriteLine("Invalid ID. Try again.");
                    i--;
                    continue;
                }

                string name = string.Join(" ", input, 1, input.Length - 1);

                persons[id] = name;
            }

            Console.Write("Enter ID to search: ");
            string? searchLine = Console.ReadLine();

            if (!uint.TryParse(searchLine, out uint searchId))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

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
}