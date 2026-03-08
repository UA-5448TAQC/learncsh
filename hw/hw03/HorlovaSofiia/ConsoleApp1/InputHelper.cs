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

        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                Console.WriteLine("Invalid integer. Please try again.");
            }
        }

        public static int ReadIntMin(string message, int minValue)
        {
            while (true)
            {
                int value = ReadInt(message);

                if (value >= minValue)
                {
                    return value;
                }

                Console.WriteLine($"Value must be >= {minValue}. Please try again.");
            }
        }

        public static int ReadIntRange(string message, int minValue, int maxValue)
        {
            while (true)
            {
                int value = ReadInt(message);

                if (value >= minValue && value <= maxValue)
                {
                    return value;
                }

                Console.WriteLine($"Value must be in range [{minValue}; {maxValue}]. Please try again.");
            }
        }

        public static float ReadFloat(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (float.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out float currentCultureValue))
                {
                    return currentCultureValue;
                }

                if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float invariantValue))
                {
                    return invariantValue;
                }

                Console.WriteLine("Invalid float number. Please try again (e.g., 1.23).");
            }
        }

        public static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal currentCultureValue))
                {
                    return currentCultureValue;
                }

                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal invariantValue))
                {
                    return invariantValue;
                }

                Console.WriteLine("Invalid number. Please try again (e.g., 3.456).");
            }
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

                Console.WriteLine("Input cannot be empty. Please try again:");
            }
        }
    }
}