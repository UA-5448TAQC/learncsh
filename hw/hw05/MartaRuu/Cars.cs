namespace ConsoleApp3
{
    class Car
    {
        private string name;
        private string color;
        private double price;
        public const string CompanyName = "Local Car Company";
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car()
        {
            name = "";
            color = "";
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
            Console.WriteLine("Enter car name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter car color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter car price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public void ChangePrice(double x)
        {
            price += price * x / 100.0;
        }
        public override string ToString()
        {
            return $"Name: {name}, Color: {color}, Price: {price}, Company: {CompanyName}";
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
            if (obj is Car c)
                return this == c;
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(name, price);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Car[] cars = new Car[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"\nCar {i + 1}:");
                    cars[i] = new Car();
                    cars[i].Input();
                }
                foreach (var car in cars)
                {
                    car.ChangePrice(-10);
                }
                Console.WriteLine("\nAfter price decrease:");
                foreach (var car in cars)
                {
                    car.Print();
                }
                Console.Write("\nEnter new color: ");
                string newColor = Console.ReadLine();
                foreach (var car in cars)
                {
                    if (car.Color.ToLower() == "white")
                    {
                        car.Color = newColor;
                    }
                }
                Console.WriteLine("\nAfter repaint:");
                foreach (var car in cars)
                {
                    car.Print();
                }
                Console.WriteLine("\nCompare car 1 and car 2:");
                if (cars[0] == cars[1])
                    Console.WriteLine("Equal");
                else
                    Console.WriteLine("Not equal");
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 01ac236f2c2c8078fba6b62d6a2da722199e1109
