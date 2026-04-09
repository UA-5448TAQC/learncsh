using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw4_Zoriana_Telychko
{
    //Ask the user to enter a month number (1–12). Output the number of days in this month.

    
    internal class Task_2
    {
        static void Main()
        {
            Console.WriteLine("Enter a month number (1-12): ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 4: //April
                case 6: //June
                case 9: //September
                case 11: //November
                    Console.WriteLine("Entered month has 30 days."); break;
                case 2:
                    Console.WriteLine("Entered month has 28 or 29 days."); break;
                case 1: //January
                case 3: //March
                case 5: //May
                case 7: //July
                case 8: //August
                case 10: //October
                case 12: //December
                    Console.WriteLine("Entered month has 31 days."); break;
                default:
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12."); break;
            }
        }

    }
}
