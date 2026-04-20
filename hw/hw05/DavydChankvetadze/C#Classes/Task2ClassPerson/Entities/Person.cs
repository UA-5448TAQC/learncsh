namespace Task2ClassPerson.Entities;

internal class Person
{
    private string _name;
    private DateTime _birthYear;

    public string Name { get { return _name; } }
    public DateTime BirthYear {  get { return _birthYear; } }

    public Person()
    {
        _name = "Unknown";
        _birthYear = DateTime.Today;
    }

    public Person(string name, DateTime birthYear)
    {
        _name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name.Trim();
        _birthYear = birthYear.Date;
    }

    public int Age()
    {
        int age = DateTime.Today.Year - _birthYear.Year;

        if (_birthYear.Date > DateTime.Today.AddYears(-age))
        {
            age--;
        }

        return age < 0 ? 0 : age;
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        string enteredName = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(enteredName))
        {
            _name = "Unknown";
        }
        else
        {
            _name = enteredName.Trim();
        }

        while (true)
        {
            Console.Write("Enter birth date (yyyy-mm-dd): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (DateTime.TryParse(input, out DateTime birthDate) && birthDate <= DateTime.Today)
            {
                _birthYear = birthDate.Date;
                break;
            }

            Console.WriteLine("Invalid date. Please enter a valid past or current date.");
        }
    }

    public void ChangeName(string newName)
    {
        if (!string.IsNullOrWhiteSpace(newName))
        {
            _name = newName.Trim();
        }
    }

    public override string ToString()
    {
        return $"Name: {_name}, Age: {Age()}";
    }

    public void Output()
    {
        Console.WriteLine(this);
    }

    public override bool Equals(object? obj)
    {
        return obj is Person other &&
               string.Equals(_name, other._name, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return _name.GetHashCode();
    }

    public static bool operator ==(Person? left, Person? right)
    {
        if (ReferenceEquals(left, right))
            return true;

        if (left is null || right is null)
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !(left == right);
    }
}
