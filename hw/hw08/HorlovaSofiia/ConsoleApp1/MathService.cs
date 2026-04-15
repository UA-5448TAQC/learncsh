using System;

namespace ConsoleApp1
{
    internal static class MathService
    {
        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static double DivideDouble(double a, double b)
        {
            if (b == 0)
            {
                throw new DivisionByZeroCustomException();
            }

            return a / b;
        }

        public static int ReadNumber(int start, int end)
        {
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                throw new FormatException("Input is not a number.");
            }

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(number),
                    $"Number must be in range [{start}..{end}].");
            }

            return number;
        }
    }
}