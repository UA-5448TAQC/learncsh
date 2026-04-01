using System;
using System.Linq;
using System.IO;

namespace hw07_Task1_IrynaMykhailevych
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person("Alice");
            Teacher teacher1 = new Teacher("Bob", 2000, "Mathematics");
            Developer developer1 = new Developer("Charlie", 3000, "Senior");

            people.Add(person1);
            people.Add(teacher1);
            people.Add(developer1);

            foreach (var p in people)
            {
                p.Print();
            }

            Console.Write("Enter name: ");
            string name = Console.ReadLine() ?? "";

            var found = people.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
            if (found != null)
            {
                found.Print();
            }
            else
            {
                Console.WriteLine("Person not found");
            }

            var sorted = people.OrderBy(p => p.Name).ToList();
            File.WriteAllLines("output.txt", sorted.Select(p => p.Name));

            Console.WriteLine("Employees sorted by salary:");

            var employees = people.OfType<Staff>().ToList();
            var sortedBySalary = employees.OrderBy(s => s.Salary);

            foreach (var emp in sortedBySalary)
            {
                emp.Print();
            }
        }
    }
}
