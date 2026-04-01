using System;

namespace ConsoleApp1
{
    internal class Car
    {
        private string name;
        private string color;
        private double price;

        public const string CompanyName = "AutoCompany";

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

        public Car()
        {
            name = string.Empty;
            color = string.Empty;
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
            name = InputHelper.ReadNonEmptyString("Enter car name:");
            color = InputHelper.ReadNonEmptyString("Enter car color:");
            price = InputHelper.ReadPositiveDouble("Enter car price:");
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
            return $"Name: {name}, Color: {color}, Price: {price:F2}, Company: {CompanyName}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Car other)
            {
                return false;
            }

            return name == other.name && price == other.price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, price);
        }

        public static bool operator ==(Car? a, Car? b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car? a, Car? b)
        {
            return !(a == b);
        }
    }
}