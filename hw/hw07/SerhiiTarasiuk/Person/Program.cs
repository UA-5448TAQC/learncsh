
namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person("Mukuta"),
                new Teacher("Mukola", "Fiz-ra", 49999),
                new Developer("Muron", "Senior", 40000),
                new Teacher("Marko", "OBG", 500000),
                new Developer("Misha", "Junior", 18000)
            };

            Console.WriteLine("All people:");
            foreach (Person person in people)
            {
                person.Print();
            }

            Console.WriteLine();
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();

            Person foundPerson = people.FirstOrDefault(p => p.Name == name);

            if (foundPerson != null)
            {
                Console.WriteLine("Found person:");
                foundPerson.Print();
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            List<Person> sortedPeople = people.OrderBy(p => p.Name).ToList();

            File.WriteAllLines("output.txt", sortedPeople.Select(p => p.ToString()));

            Console.WriteLine();
            Console.WriteLine("Sorted people:");
            foreach (Person person in sortedPeople)
            {
                person.Print();
            }

            Console.WriteLine();
            Console.WriteLine("Data saved to output.txt");

            List<Staff> employees = people.OfType<Staff>().ToList();
            List<Staff> sortedBySalary = employees.OrderBy(s => s.Salary).ToList();

            Console.WriteLine();
            Console.WriteLine("Employees sorted by salary:");
            foreach (Staff employee in sortedBySalary)
            {
                employee.Print();
            }
        }
    }
}