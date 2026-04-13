using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task2
    {
        public static void Run()
        {
            int month = ReadInt("Enter a month number (1–12): ");

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month number.");
                month = ReadInt("Please enter a number between 1 and 12: ");
            }

            PrintDaysInMonth(month);
        }
        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter the valid number: ");
                input = Console.ReadLine();
            }
            return result;
        }
        static void PrintDaysInMonth(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("The month has 31 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("The month has 30 days.");
                    break;
                case 2:
                    Console.WriteLine("The month has 28 days.");
                    break;
            }
        }
    }
}
