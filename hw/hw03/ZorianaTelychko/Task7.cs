using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw3_Zoriana_Telychko
{
    //Enter integer number h, representing the time of day(hour).
    //Depending on the time of day, output greetings("Good morning!", "Good afternoon!",
    //"Good evening!“ or "Good night!")
    internal class Task7
    {
        private static void Main(string[] args)

        {
            Console.WriteLine("Enter time: ");
            string time_Input = Console.ReadLine();
            if (int.TryParse(time_Input, out int time))
            {
                if (time >= 0 && time < 5)
                {
                    Console.WriteLine("Good night!");
                }
                else if (time >= 5 && time < 12)
                {
                    Console.WriteLine("Good morning!");
                }
                else if (time >= 12 && time < 18)
                {
                    Console.WriteLine("Good afternoon!");
                }
                else if (time >= 18 && time < 24)
                {
                    Console.WriteLine("Good evening!");
                }
                else
                {
                    Console.WriteLine("Error: Time must be between 0 and 23.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
            }

        }
    }
}
