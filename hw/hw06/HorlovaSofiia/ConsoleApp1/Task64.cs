using System.Collections.Generic;
namespace ConsoleApp1
{
    internal static class Task64
    {
        public static void Run()
        {
            Console.WriteLine("Homework 6.4 — Dictionary");

            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            for (int i = 0; i < 7; i++)
            {
                uint id = InputHelper.ReadUInt($"Enter ID for person #{i + 1}:");

                while (persons.ContainsKey(id))
                {
                    Console.WriteLine("This ID already exists. Enter another ID.");
                    id = InputHelper.ReadUInt($"Enter ID for person #{i + 1}:");
                }

                string name = InputHelper.ReadNonEmptyString($"Enter name for person #{i + 1}:");
                persons.Add(id, name);
            }

            uint searchId = InputHelper.ReadUInt("Enter ID to find:");

            if (persons.ContainsKey(searchId))
            {
                Console.WriteLine($"Name: {persons[searchId]}");
            }
            else
            {
                Console.WriteLine("ID not found.");
            }

            InputHelper.PrintSeparator();
        }
    }
}