using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw06_Task4_IrynaMykhailevych
{
    internal class ProgramTask4
    {
        static void Main()
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            for (int i = 0; i < 7; i++)
            {
                uint id;
                string name;
                Console.WriteLine($"Enter ID for person {i + 1}:");
                string inputId = Console.ReadLine() ?? "";
                uint.TryParse(inputId, out id);
                Console.WriteLine($"Enter name for person {i + 1}:");
                name = Console.ReadLine() ?? "";
                persons.Add(id, name);
            }

            uint searchId;
            Console.WriteLine("Enter ID:");
            string searchInput = Console.ReadLine() ?? "";
            uint.TryParse(searchInput, out searchId);

            if (persons.ContainsKey(searchId))
            {
                Console.WriteLine(persons[searchId]);
            }
            else
            {
                Console.WriteLine("ID not found.");
            }
        }
    }
}
