namespace ConsoleApp3
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Person: Name = {Name}");
        }
        public override string ToString()
        {
            return $"Person: Name = {Name}";
        }
    }
    class Staff : Person
    {
        public decimal Salary { get; set; }
        public Staff(string name, decimal salary) : base(name)
        {
            Salary = salary;
        }
        public override void Print()
        {
            Console.WriteLine($"Staff: Name = {Name}, Salary = {Salary}");
        }
        public override string ToString()
        {
            return $"Staff: Name = {Name}, Salary = {Salary}";
        }
    }
    class Teacher : Staff
    {
        public string Subject { get; set; }
        public Teacher(string name, string subject, decimal salary) : base(name, salary)
        {
            Subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine($"Teacher: Name = {Name}, Subject = {Subject}, Salary = {Salary}");
        }
        public override string ToString()
        {
            return $"Teacher: Name = {Name}, Subject = {Subject}, Salary = {Salary}";
        }
    }
    class Developer : Staff
    {
        public string Level { get; set; }
        public Developer(string name, string level, decimal salary) : base(name, salary)
        {
            Level = level;
        }
        public override void Print()
        {
            Console.WriteLine($"Developer: Name = {Name}, Level = {Level}, Salary = {Salary}");
        }
        public override string ToString()
        {
            return $"Developer: Name = {Name}, Level = {Level}, Salary = {Salary}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person("John"),
            new Teacher("Alice", "Math", 25000),
            new Developer("Bob", "Senior", 40000),
            new Teacher("Emma", "Physics", 28000),
            new Developer("David", "Junior", 18000)
        };
            Console.WriteLine("All people");
            foreach (var p in people)
            {
                p.Print();
            }
            Console.WriteLine();
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();
            var found = people.FirstOrDefault(p =>
                p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();
            if (found != null)
            {
                Console.WriteLine("Found person");
                found.Print();
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted by name");
            var sortedPeople = people.OrderBy(p => p.Name).ToList();
            foreach (var p in sortedPeople)
            {
                p.Print();
            }
            File.WriteAllLines("output.txt", sortedPeople.Select(p => p.ToString()));
            Console.WriteLine("\nSorted data was saved to output.txt");
            Console.WriteLine();
            Console.WriteLine("Employees only (Teacher + Developer), sorted by salary");
            List<Staff> employees = people.OfType<Staff>().OrderBy(s => s.Salary).ToList();
            foreach (var emp in employees)
            {
                emp.Print();
            }
        }
    }
}









