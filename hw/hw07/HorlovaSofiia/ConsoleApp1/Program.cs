using System;
namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunTask1();
            Console.WriteLine(new string('-', 60));
            RunTask2();

            Console.WriteLine();
            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }

        private static void RunTask1()
        {
            Console.WriteLine("Task 1 — Person, Staff, Teacher, Developer");

            List<Person> people = new List<Person>
            {
                new Person("John"),
                new Teacher("Alice", 25000, "Math"),
                new Developer("Bob", 32000, "Senior"),
                new Person("Emma"),
                new Teacher("Kate", 28000, "Physics"),
                new Developer("Alex", 22000, "Junior")
            };

            Console.WriteLine("All people:");
            foreach (Person person in people)
            {
                person.Print();
            }

            Console.WriteLine();
            Console.WriteLine("Enter name to search:");
            string searchName = Console.ReadLine() ?? string.Empty;

            Person? foundPerson = people.Find(p =>
                p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (foundPerson != null)
            {
                Console.WriteLine("Found person:");
                foundPerson.Print();
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            people.Sort((first, second) =>
                string.Compare(first.Name, second.Name, StringComparison.OrdinalIgnoreCase));

            FileService.SavePeopleToFile("output.txt", people);

            Console.WriteLine();
            Console.WriteLine("Sorted people were saved to output.txt");

            List<Staff> employees = new List<Staff>();

            foreach (Person person in people)
            {
                if (person is Staff staff)
                {
                    employees.Add(staff);
                }
            }

            employees.Sort((first, second) => first.Salary.CompareTo(second.Salary));

            Console.WriteLine();
            Console.WriteLine("Employees sorted by salary:");
            foreach (Staff employee in employees)
            {
                employee.Print();
            }
        }

        private static void RunTask2()
        {
            Console.WriteLine("Task 2 — Shapes");

            List<Shape> shapes = new List<Shape>
            {
                new Circle("Circle1", 3),
                new Square("Square1", 4),
                new Circle("Circle2", 5),
                new Square("Square2", 2)
            };

            ShapeOperator.GetInfo(shapes);
            ShapeOperator.GetLargestPerimeter(shapes);
            ShapeOperator.Sort(shapes);
        }
    }
}