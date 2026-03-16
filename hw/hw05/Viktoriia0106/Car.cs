using System;

namespace ConsoleAppHW05
{
    class Car
    {
        private string name;
        private string color;
        private double price;
        private const string CompanyName = "MyAuto";

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car() { }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            Console.WriteLine($"--- Enter data for {CompanyName} ---");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.Write("Price: ");
            price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public void ChangePrice(double x)
        {
            price += price * x / 100;
        }

        public static bool operator ==(Car a, Car b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car a, Car b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"Name: {name}, Color: {color}, Price: {price:F2}, Company: {CompanyName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Car car) return this == car;
            return false;
        }

        public override int GetHashCode()
        {
            return (name, price).GetHashCode();
        }
    }
}