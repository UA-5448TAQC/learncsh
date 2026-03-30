
namespace ConsoleApp1
{
    class Car
    {
        private string name;
        private string color;
        private double price;

        public const string CompanyName = "MyCompany";

        public string Color
        {
            get { return color; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    color = value;
                }
            }
        }

        public Car()
        {
            name = "Unknown";
            color = "Unknown";
            price = 0;
        }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            Console.Write("Enter car name: ");
            name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Invalid input. Enter car name again: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter car color: ");
            color = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(color))
            {
                Console.Write("Invalid input. Enter car color again: ");
                color = Console.ReadLine();
            }

            Console.Write("Enter car price: ");

            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Invalid input. Enter a valid price: ");
            }
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void ChangePrice(double x)
        {
            price = price + price * x / 100.0;
        }

        public override string ToString()
        {
            return $"Name: {name}, Color: {color}, Price: {price:F2}, Company: {CompanyName}";
        }

        public static bool operator ==(Car a, Car b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car a, Car b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Car other)
                return this == other;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, price);
        }
    }
}