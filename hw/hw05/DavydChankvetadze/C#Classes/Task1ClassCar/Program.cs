namespace Task1ClassCar;

internal class Car
{
    private string _name;
    private string _color;
    private double _price;

    public const string CompanyName = "AutoMotive Inc.";

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public Car()
    {
        _name = "Unknown";
        _color = "White";
        _price = 0;
    }

    public Car(string name, string color, double price)
    {
        _name = name;
        _color = color;
        _price = price;
    }

    public void Input()
    {
        Console.Write("Enter car name: ");
        _name = Console.ReadLine();

        Console.Write("Enter car color: ");
        _color = Console.ReadLine();

        while (true)
        {
            Console.Write("Enter car price: ");
            if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
            {
                _price = price;
                break;
            }

            Console.WriteLine("Invalid price. Please enter a valid non-negative number.");
        }
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public void ChangePrice(double percent)
    {
        _price += _price * percent / 100.0;
    }

    public void Repaint(string newColor)
    {
        if (_color.ToLower() == "white")
        {
            _color = newColor;
        }
    }

    public override string ToString()
    {
        return $"Name: {_name}, Color: {_color}, Price: {_price:F2}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Car other)
        {
            return _name == other._name && _price == other._price;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_name, _price);
    }

    public static bool operator ==(Car left, Car right)
    {
        if (ReferenceEquals(left, right))
            return true;

        if (left is null || right is null)
            return false;

        return left._name == right._name && left._price == right._price;
    }

    public static bool operator !=(Car left, Car right)
    {
        return !(left == right);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Car car1 = new();
        Car car2 = new();
        Car car3 = new();

        Console.WriteLine("Enter data for Car 1:");
        car1.Input();

        Console.WriteLine("Enter data for Car 2:");
        car2.Input();

        Console.WriteLine("Enter data for Car 3:");
        car3.Input();

        Console.WriteLine("\nCars before price change:");
        car1.Print();
        car2.Print();
        car3.Print();

        car1.ChangePrice(-10);
        car2.ChangePrice(-10);
        car3.ChangePrice(-10);

        Console.WriteLine("\nCars after price change:");
        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);

        Console.Write("\nEnter new color for white cars: ");
        string newColor = Console.ReadLine();

        car1.Repaint(newColor);
        car2.Repaint(newColor);
        car3.Repaint(newColor);

        Console.WriteLine("\nCars after repaint:");
        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);

        if (car1 == car2)
            Console.WriteLine("\nCar 1 and Car 2 are equal.");
        else
            Console.WriteLine("\nCar 1 and Car 2 are not equal.");
    }
}
