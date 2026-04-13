namespace Task2; // Class Person

public class Person
{
    private string personName;
    private DateTime birthYear;

    public string Name
    {
        get { return personName; }
    }

    public DateTime BirthYear
    {
        get { return birthYear; }
    }
    //public Person() //Дефолтний конструктор

    //    {
    //    Person p1 = new Person("Ivan", new DateTime(2000, 1, 1));
    //    Person p2 = new Person("Oleh", new DateTime(2010, 5, 10));
    //    Person p3 = new Person("Anna", new DateTime(1995, 3, 15));
    //    Person p4 = new Person("Maria", new DateTime(2008, 7, 20));
    //    Person p5 = new Person("Petro", new DateTime(1985, 11, 30));
    //    Person p6 = new Person("Olha", new DateTime(2012, 9, 5));
    //    };

    public Person() //Параметризований конструктор
    {
        personName = "Unknown";
        birthYear = DateTime.MinValue;
    }

    public Person(string name, DateTime birthYear)
    {
        this.personName = name;
        this.birthYear = birthYear;
    }

    public int Age()
    {
        DateTime today = DateTime.Now;
        int age = today.Year - birthYear.Year;

        if (today < birthYear.AddYears(age))
        {
            age--;
        }

        return age;
    }

    public void Input() //Input метод
    {

        Console.WriteLine("Enter Name: ");
        personName = Console.ReadLine();

        Console.WriteLine("Enter your date of birth (MM/DD/YYYY): ");
        string input = Console.ReadLine();

        birthYear = DateTime.Parse(input);

    }
    //    public void ChangeName(string newName)  //Зміна імені
    //    {
    //        Name = newName;
    //    }
    //    public override string ToString() //ToString метод
    //    {
    //        return ($"Your name is {PersonName}, your date of birth - {birthYear} and you have already {Price} ");
    //    }
    //}
    public void ChangeName(string newName) //Зміна імені
    {
        personName = newName;
    }

    public override string ToString() //ToString метод
    {
        return $"Name: {personName}, Birth date: {birthYear:yyyy-MM-dd}, Age: {Age()}";
    }

    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public static bool operator ==(Person p1, Person p2)
    {
        if (ReferenceEquals(p1, p2))
            return true;

        if (p1 is null || p2 is null)
            return false;

        return p1.personName == p2.personName;
    }

    public static bool operator !=(Person p1, Person p2)
    {
        return !(p1 == p2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Person other)
            return personName == other.personName;

        return false;
    }

    public override int GetHashCode()
    {
        return personName.GetHashCode();
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
            Console.WriteLine($"\nEnter data for person {i + 1}:");
            people[i].Input();
        }

        Console.WriteLine("\nInitial information:");
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age()}");
        }

        foreach (Person person in people)
        {
            if (person.Age() < 16)
            {
                person.ChangeName("Very Young");
            }
        }

        Console.WriteLine("\nUpdated information:");
        foreach (Person person in people)
        {
            person.Output();
        }

        Console.WriteLine("\nPersons with same names:");
        bool found = false;

        for (int i = 0; i < people.Length; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                if (people[i] == people[j])
                {
                    Console.WriteLine($"{people[i].Name} and {people[j].Name} have the same name.");
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
