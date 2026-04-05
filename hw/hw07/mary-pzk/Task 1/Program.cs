using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person("John"),
            new Teacher("Alice", "Math", 1200),
            new Teacher("Emma", "Physics", 950),
            new Teacher("Olivia", "English", 1100),

            new Developer("Bob", "Senior", 800),
            new Developer("Liam", "Junior", 400),
            new Developer("Noah", "Middle", 700)
        };

            Console.WriteLine("All people:");
            foreach (var p in people)
            {
                p.Print();
            }

            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();

            var found = people.FirstOrDefault(p => p.Name == name);
            Console.WriteLine("\nSearch result:");
            if (found != null)
            {
                found.Print();
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            var sorted = people.OrderBy(p => p.Name).ToList();
            File.WriteAllLines("output.txt", sorted.Select(p => p.ToString()));

            Console.WriteLine("\nEmployees sorted by salary:");
            var employees = people.OfType<Staff>().ToList();
            var sortedBySalary = employees.OrderBy(s => s.Salary);

            foreach (var emp in sortedBySalary)
            {
                emp.Print();
            }
        }
    }
}
