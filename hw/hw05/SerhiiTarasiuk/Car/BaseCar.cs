using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {
        private string name;
        private string color;
        private double price;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {
            name = "Unknown";
            color = "white";
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
            name = HW_04.Helpers.ProgramHelpers.ReadNonEmptyString("Enter car name: ");
            color = HW_04.Helpers.ProgramHelpers.ReadNonEmptyString("Enter car color: ");
            price = HW_04.Helpers.ProgramHelpers.ReadPositiveInt("Enter car price: ");
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine();
        }

        public void ChangePrice(double x)
        {
            price += price * x / 100.0;
        }

        public void Repaint(string newColor)
        {
            HW_04.Helpers.ProgramHelpers.ReadNonEmptyString(newColor);
            color = newColor;
        }

        public override string ToString()
        {
            return $@"

                                   _..-------++._
                               _.-'/ |      _||  \""--._
                         __.--'`._/_\j_____/_||___\    `----.
                    _.--'_____    |          \     _____    /
                  _j    /,---.\   |        =o |   /,---.\   |_
                 [__]==// .-. \\==`===========/==// .-. \\=[__]
                   `-._|\ `-' /|___\_________/___|\ `-' /|_.'  >>> Wroom-wroom !!!
                         `---'                     `---'

            Name: {name}, Color: {color}, Price: {price}";
        }

       
    }
}
