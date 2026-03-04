using System;

namespace hw03_IrynaMykhailevych
{
    internal class Task5
    {
        public static void Run()
        {
            int day = ReadInt("Enter day: ");
            int month = ReadInt("Enter month: ");

            bool isValid = IsValidDate(day, month);

            PrintResults(isValid);
        }
        static int ReadInt(string message)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                int result;
                while (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Invalid input. Please enter the valid value: ");
                    input = Console.ReadLine();
                }
                return result;
            }
        static bool IsValidDate(int day, int month)
            {
                if (month < 1 || month > 12 || day < 1)
                {
                    return false;
                }

                if (month == 2)
                {
                    return day <= 28;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    return day <= 30;
                }
                else
                {
                    return day <= 31;
                }
            }
        static void PrintResults(bool isValid)
        {
            if (isValid)
            {
                Console.WriteLine("The date is valid.");
            }
            else
            {
                Console.WriteLine("The date is invalid.");
            }
        }
    }
}
