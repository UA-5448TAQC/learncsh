using System;

namespace hw3_Zoriana_Telychko
{
    enum Month
    {
        January = 1, February, March, April, May, June,
        July, August, September, October, November, December
    }

    enum DaysInMonth
    {
        January = 31, February = 28, March = 31, April = 30,
        May = 31, June = 30, July = 31, August = 31,
        September = 30, October = 31, November = 30, December = 31
    }

    internal class Task5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month number (1-12): ");
            string month_Input = Console.ReadLine();

            Console.Write("Enter day number (1-31): ");
            string day_Input = Console.ReadLine();

            if (int.TryParse(month_Input, out int monthNumber) && int.TryParse(day_Input, out int dayNumber))
            {
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    Month enteredMonth = (Month)monthNumber;
                    string monthName = enteredMonth.ToString();

                    
                    int maxDays = (int)Enum.Parse(typeof(DaysInMonth), monthName);

                    
                    if (dayNumber >= 1 && dayNumber <= maxDays)
                    {
                        Console.WriteLine($"Success! {monthName} {dayNumber} is a valid date.");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {monthName} only has {maxDays} days. You entered {dayNumber}.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Month must be between 1 and 12.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
        }
    }
}