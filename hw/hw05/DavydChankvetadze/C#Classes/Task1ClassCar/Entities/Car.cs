namespace Task1ClassCar.Entities;

internal class Car
{
    private string _name;
    private string _color;
    private double _price;

    public const string CompanyName = "AutoMotive Inc.";

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value.Trim();
    }

    public string Color
    {
        get => _color;
        set => _color = string.IsNullOrWhiteSpace(value) ? "White" : value.Trim();
    }

    public double Price
    {
        get => _price;
        set => _price = value >= 0 ? value : 0;
    }

    public Car()
    {
        _name = "Unknown";
        _color = "White";
        _price = 0;
    }

    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    public void Input()
    {
        Console.Write("Enter car name: ");
        Name = Console.ReadLine() ?? "Unknown";

        Console.Write("Enter car color: ");
        Color = Console.ReadLine() ?? "White";

        while (true)
        {
            Console.Write("Enter car price: ");
            if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
            {
                Price = price;
                break;
            }

            Console.WriteLine("Invalid price. Please enter a valid non-negative number.");
        }
    }

    public void Print()
    {
        Console.WriteLine(this);
    }

    public void ChangePrice(double percent)
    {
        _price += _price * percent / 100.0;
    }

    public void Repaint(string newColor)
    {
        if (string.Equals(_color, "White", StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(newColor))
        {
            _color = newColor.Trim();
        }
    }

    public override string ToString()
    {
        return $"Name: {_name}, Color: {_color}, Price: {_price:F2}, Company: {CompanyName}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Car other &&
               string.Equals(_name, other._name, StringComparison.OrdinalIgnoreCase) &&
               _price == other._price;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_name.ToLower(), _price);
    }

    public static bool operator ==(Car? left, Car? right)
    {
        if (ReferenceEquals(left, right))
            return true;

        if (left is null || right is null)
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(Car? left, Car? right)
    {
        return !(left == right);
    }
}
