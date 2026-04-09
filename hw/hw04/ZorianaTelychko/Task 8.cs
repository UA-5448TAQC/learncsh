using System;
using System.Collections.Generic;
using System.Text;

namespace hw4_Zoriana_Telychko
{
    internal class Task_8
    {

        static void Main()
        {
            Console.Write("Enter a year: ");
            string user_input = Console.ReadLine();

            if (int.TryParse(user_input, out int year))

            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }
    }
}
