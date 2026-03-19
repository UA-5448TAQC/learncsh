using System;

namespace hw03_IrynaMykhailevych
{
    internal class Task6
    {
        public static void Run()
        {
            double number = ReadDouble("Enter a double number: ");

            int firstDigit = GetFirstDigitAfterDecimal(number);
            int secondDigit = GetSecondDigitAfterDecimal(number);

            int sum = firstDigit + secondDigit;

            PrintResult(firstDigit, secondDigit, sum);
        }
        static double ReadDouble(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            double result;
            while (!double.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter the valid number: ");
                input = Console.ReadLine();
            }
            return result;
        }
        static int GetFirstDigitAfterDecimal(double number)
        {
            number = Math.Abs(number);

            double fractionalPart = number - (int)number;
            int first = (int)(fractionalPart * 10);

            return first;
        }
        static int GetSecondDigitAfterDecimal(double number)
        {
            number = Math.Abs(number);

            double fractionalPart = number - (int)number;
            int second = (int)(fractionalPart * 100) % 10;

            return second;
        }
        static void PrintResult(int firstDigit, int secondDigit, int sum)
        {
            Console.WriteLine($"The first digit after the decimal point is: {firstDigit}");
            Console.WriteLine($"The second digit after the decimal point is: {secondDigit}");
            Console.WriteLine($"The sum of the first and second digits is: {sum}");

        }
    }
}
