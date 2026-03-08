using HW_04.Helpers;

namespace HW_04
{
    internal class Task08
    {
        public static void Run()
        {
            int year = ProgramHelpers.ReadInt("Enter a year:");
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
