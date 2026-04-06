
namespace ConsoleApp1
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

            if (DateTime.Now < birthYear.AddYears(age))
            {
                age--;
            }

            return age;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Invalid input. Enter name again: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter birth year (yyyy): ");

            int year;

            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Invalid input. Enter year again: ");
            }

            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                name = newName;
            }
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
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return string.Equals(a.name, b.name, StringComparison.OrdinalIgnoreCase);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return this == other;

            return false;
        }

        public override int GetHashCode()
        {
            return name?.ToLower().GetHashCode() ?? 0;
        }
    }
}