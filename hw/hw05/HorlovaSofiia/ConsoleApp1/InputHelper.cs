using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal static class InputHelper
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 50));
        }

        public static string ReadNonEmptyString(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Input cannot be empty. Try again.");
            }
        }

        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double currentCultureValue))
                {
                    return currentCultureValue;
                }

                if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double invariantValue))
                {
                    return invariantValue;
                }

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        public static double ReadPositiveDouble(string message)
        {
            while (true)
            {
                double value = ReadDouble(message);

                if (value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Value must be non-negative.");
            }
        }

        public static DateTime ReadDate(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (DateTime.TryParse(input, out DateTime result))
                {
                    return result;
                }

                Console.WriteLine("Invalid date. Use a valid format, for example 2005-10-21.");
            }
        }

        public static DateTime ReadBirthDate(string message)
        {
            while (true)
            {
                DateTime date = ReadDate(message);

                if (date <= DateTime.Today)
                {
                    return date;
                }

                Console.WriteLine("Birth date cannot be in the future.");
            }
        }
    }
}