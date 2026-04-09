using System;
using System.Collections.Generic;
using System.Text;

namespace hw4_Zoriana_Telychko
{
    internal class Task_6
    {
        /* Enter the name of the drink:

coffee
tea
juice
water
Print:

Drink name
Price
(Use switch statement.)
        */

        static void Main()
        {
            Console.WriteLine("Enter the name of the drink: ");
            string drink = Console.ReadLine().ToLower();
            double price = 0;

            switch (drink)
            {
                case "coffee":
                    price = 2.50;
                    break;
                case "tea":
                    price = 1.75;
                    break;
                case "juice":
                    price = 3.00;
                    break;
                case "water":
                    price = 1.00;
                    break;
                default:
                    Console.WriteLine("Not found drink name. Please enter one of the following: coffee, tea, juice, water.");
                    return;
            }

            Console.WriteLine($"Drink: {drink}, Price: {price}");

        }
    }
}
