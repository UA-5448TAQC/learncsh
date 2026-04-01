using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleAppVRHW07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peopleList = ExecuteTask6_1();
            ExecuteAdvancedTask(peopleList);
            ExecuteTask7_2();
            
        }
        static List<Person> ExecuteTask6_1()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Vika"));
            people.Add(new Teacher("Oksana", 25000, "Math"));
            people.Add(new Developer("Dmitry", 60000, "Senior"));
            people.Add(new Developer("Alex", 30000, "Middle"));
            people.Add(new Developer("Mariia", 20000, "Junior"));



            var sortedPeople = people.OrderBy(p => p.Name).ToList();

            foreach (Person p in sortedPeople)
            {
                p.Print();
            }
            Console.Write("Enter name to search: ");
            string enteredName = Console.ReadLine();
            foreach (Person p in sortedPeople)
            {
                if (p.Name == enteredName)
                {
                    p.Print();
                }

            }
            List<string> lines = new List<string>();
            foreach (Person p in sortedPeople)
            {
                lines.Add(p.ToString());
            }
            File.WriteAllLines("output.txt", lines);
            Console.WriteLine("Data saved to output.txt");
            return people;
        } //ExecuteTask6_1//

        static void ExecuteAdvancedTask(List<Person> people)
            {
            // Staff objects only//
            var staffOnly = people.OfType<Staff>().ToList();

            // Sort by salary//
            var sortedStaff = staffOnly.OrderBy(s => s.Salary).ToList();

            // Print sorted staff//
            foreach (Staff staff in sortedStaff)
            {
                staff.Print();
            }
        } //ExecuteAdvancedTask//

        static void ExecuteTask7_2()
        {
            // Shapes list creation with Circle and Square objects//
            List<Shape> shapes = new List<Shape>
    {
        new Circle("FirstCircle", 10.5),
        new Square("FirstSquare", 12.2),
        new Circle("SmallCircle", 3.0),
        new Square("BigSquare", 20.0)
    };

            // Displaying information about each shape//
            Console.WriteLine("\n--- Shapes Info ---");
            Operator.GetInfO(shapes);

            Console.WriteLine("\n--- Largest Perimeter ---");
            Operator.GetLargestPerimeter(shapes);

            Console.WriteLine("\n--- Sorted by Area ---");
            Operator.SortByArea(shapes); // Sorting shapes by area and displaying the sorted list (by IComparable)//
        }

    } //class//
} //namespace//
