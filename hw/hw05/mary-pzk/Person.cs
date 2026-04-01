namespace HW5
{
    public class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public DateTime BirthYear
        {
            get
            {
                return birthYear;
            }
        }
        public Person() { }

        public Person(string n, DateTime b)
        {
            name = n;
            birthYear = b;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter birth date (yyyy-mm-dd): ");
            birthYear = DateTime.Parse(Console.ReadLine());
        }

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthYear.Year;

            if (now < birthYear.AddYears(age))
            {
                age--;
            }

            return age;
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {Age()}";
        }

        public static bool operator ==(Person a, Person b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.name == b.name;
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (other is null)
                return false;

            return this == other;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6];
            persons[0] = new Person();
            persons[1] = new Person();
            persons[2] = new Person();
            persons[3] = new Person();
            persons[4] = new Person();
            persons[5] = new Person();


            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"\nEnter data for person #{i + 1}");
                persons[i].Input();
            }

            Console.WriteLine("\nPerson information:");
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age() < 16)
                    persons[i].ChangeName("Very Young");
            }

            Console.WriteLine("\nUpdated person information: ");
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.WriteLine("\nChecking whether there are persons with the same name...");
            bool found = false;

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine("Same name: " + persons[i].Name);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("All names are unique.");
            }
        }
    }
}
