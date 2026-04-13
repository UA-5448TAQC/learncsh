namespace Task2ClassPerson;

internal class Person
{
    private string _name;
    private DateTime _birthYear;

    public string Name
    {
        get { return _name; }
    }

    public DateTime BirthYear
    {
        get { return _birthYear; }
    }

    public Person()
    {
        _name = "Unknown";
        _birthYear = DateTime.MinValue;
    }

    public Person(string name, DateTime birthYear)
    {
        _name = name;
        _birthYear = birthYear;
    }

    public int Age()
    {
        if (_birthYear == DateTime.MinValue)
            return 0;

        int age = DateTime.Now.Year - _birthYear.Year;

        if (DateTime.Now.DayOfYear < _birthYear.DayOfYear)
            age--;

        return age;
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        _name = Console.ReadLine();

        while (true)
        {
            Console.Write("Enter birth date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                _birthYear = birthDate;
                break;
            }

            Console.WriteLine("Invalid date. Please enter a valid date.");
        }
    }

    public void ChangeName(string newName)
    {
        _name = newName;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Age: {Age()}";
    }

    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return _name == other._name;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return _name != null ? _name.GetHashCode() : 0;
    }

    public static bool operator ==(Person left, Person right)
    {
        if (ReferenceEquals(left, right))
            return true;

        if (left is null || right is null)
            return false;

        return left._name == right._name;
    }

    public static bool operator !=(Person left, Person right)
    {
        return !(left == right);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[6];

        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person();
        }

        Console.WriteLine("Enter data for 6 persons:\n");

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine($"Person #{i + 1}:");
            people[i].Input();
            Console.WriteLine();
        }

        Console.WriteLine("Persons information:");
        for (int i = 0; i < people.Length; i++)
        {
            people[i].Output();
        }

        for (int i = 0; i < people.Length; i++)
        {
            if (people[i].Age() < 16)
            {
                people[i].ChangeName("Very Young");
            }
        }

        Console.WriteLine("\nUpdated information:");
        for (int i = 0; i < people.Length; i++)
        {
            people[i].Output();
        }

        Console.WriteLine("\nPersons with the same names:");
        bool found = false;

        for (int i = 0; i < people.Length; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                if (people[i] == people[j])
                {
                    Console.WriteLine($"{people[i].Name} == {people[j].Name}");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No persons with the same names were found.");
        }
    }
}
