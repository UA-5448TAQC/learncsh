namespace ConsoleApp3
{
    class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }
        public Person()
        {
            name = "Unknown";
            birthYear = DateTime.Now;
        }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public int Age()
        {
            int age = DateTime.Now.Year - birthYear.Year;
            if (DateTime.Now.DayOfYear < birthYear.DayOfYear)
                age--;
            return age;
        }
        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth date (yyyy-mm-dd): ");
            while (!DateTime.TryParse(Console.ReadLine(), out birthYear))
            {
                Console.Write("Invalid date! Try again (yyyy-mm-dd): ");
            }
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {Age()}";
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person a, Person b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.name == b.name;
        }
        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            return obj is Person p && this == p;
        }
        public override int GetHashCode()
        {
            return name?.GetHashCode() ?? 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}:");
                people[i] = new Person();
                people[i].Input();
            }
            Console.WriteLine("\nPeople:");
            foreach (var p in people)
            {
                if (p.Age() < 16)
                    p.ChangeName("Very Young");
                p.Output();
            }
            Console.WriteLine("\nPeople with same names:");
            bool found = false;
            for (int i = 0; i < people.Length; i++)
            {
                for (int p = i + 1; p < people.Length; p++)
                {
                    if (people[i] == people[p])
                    {
                        Console.WriteLine($"{people[i].Name} (Person {i + 1}) == {people[p].Name} (Person {p + 1})");
                        found = true;
                    }
                }
            }
            if (!found)
                Console.WriteLine("No duplicates found.");
        }

    }
}