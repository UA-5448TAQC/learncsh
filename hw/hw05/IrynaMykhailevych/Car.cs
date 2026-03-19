using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw05_IrynaMykhailevych
{
    public class Car
    {
        private string name;
        private string color;
        private double price;
        private const string CompanyName = "BMW";

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {
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

            Console.Write("Enter car color: ");
            Color = Console.ReadLine();
            
            Console.Write("Enter car price: ");
            double.TryParse(Console.ReadLine(), out price);
        } 

        public void Print()
        {
            Console.WriteLine($"\tCompany name: {CompanyName}");
            Console.WriteLine($"\tCar name: {name}");
            Console.WriteLine($"\tCar color: {Color}");
            Console.WriteLine($"\tCar price: {price}");
            Console.WriteLine("---------------");
        }

        public void ChangePrice(double x)
        {
            price = price * (1 + x / 100);
        }

        public static bool operator ==(Car a, Car b)
        {
            if (a is null && b is null)
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
            if (obj is Car otherCar)
            {
                return this == otherCar;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, price);
        }

        public override string ToString()
        {
            return $"Name: {name}, Color: {color}, Price: {price}";
        }
    }
}
