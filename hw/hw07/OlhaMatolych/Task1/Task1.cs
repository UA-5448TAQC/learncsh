using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("John"),
                new Teacher("Alice", "Math", 25000),
                new Developer("Bob", "Senior", 40000),
                new Teacher("Emma", "Physics", 27000),
                new Developer("David", "Junior", 18000)
            };

            Console.WriteLine("=== All People ===");
            foreach (var person in people)
            {
                person.Print();
            }

            Console.WriteLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            var found = people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine();
            if (found != null)
            {
                Console.WriteLine("Found:");
                found.Print();
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            var sortedPeople = people.OrderBy(p => p.Name).ToList();

            File.WriteAllLines("output.txt", sortedPeople.Select(p => p.ToString()));

            Console.WriteLine();
            Console.WriteLine("=== Sorted by Name ===");
            foreach (var person in sortedPeople)
            {
                person.Print();
            }

            Console.WriteLine();
            Console.WriteLine("=== Employees sorted by Salary ===");
            List<Staff> employees = people.OfType<Staff>().OrderBy(s => s.Salary).ToList();

            foreach (var employee in employees)
            {
                employee.Print();
            }

            Console.WriteLine();
            Console.WriteLine("Data saved to output.txt");
        }
    }
}