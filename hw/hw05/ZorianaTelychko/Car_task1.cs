using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_Zoriana_Telychko
{
    public class Car_task1
    {
        private static int count = 0;
        private string name;
        private string color;
        private double price;
        private const string companyName = "SoftServe";

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car_task1() { }

        public Car_task1(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            int currentCount = ++count; 
            Console.WriteLine($"---> Entering data for car {currentCount} <---");
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter color: ");
            color = Console.ReadLine();

            Console.Write("Enter price: ");
            price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {

            Console.WriteLine($"Car: {name}, Color: {color}, Price: {price:F2}");
        }

        public void ChangePrice(double x)
        {
            // Формула: ціна = ціна + (ціна * відсоток / 100)
            this.price += price * x / 100;
        }

        public static bool operator ==(Car_task1 a, Car_task1 b)
        {
            // Порівнюємо властивості. Якщо обидві збігаються — повертаємо true.
            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car_task1 a, Car_task1 b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Car_task1 otherCar)
            {
                return (otherCar == this); // Використовуємо оператор == для порівняння
            }
            return false;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, price); // Генеруємо хеш-код на основі властивостей, які використовуються для порівняння
        }

        public override string ToString()
        {
            return $"Company: {companyName}\tName: {name}\tColor: {color}\tPrice: {price:F2}";
        }
    }

}

