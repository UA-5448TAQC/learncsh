namespace HW5
{
    public class Car
    {
        private string name;
        private string color;
        private double price;
        public const string CompanyName = "bestCompany";

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Car() { }

        public Car(string n, string c, double p)
        {
            name = n;
            price = p;
            color = c;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter color: ");
            color = Console.ReadLine();

            Console.Write("Enter price: ");
            price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("\tName: " + name);
            Console.WriteLine("\tColor: " + color);
            Console.WriteLine("\tPrice: " + price);

        }

        public void ChangePrice(double x)
        {
            x = x / 100;
            price = price + (price * x);
        }

        public static bool operator ==(Car a, Car b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car a, Car b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Car other = obj as Car;

            if (other is null)
                return false;

            return this == other;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() ^ price.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {name}, Color: {color}, Price: {price}";
        }
    }
}
