using System;

namespace ConsoleApp1
{
    internal static class InputHelper
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 60));
        }

        public static int ReadInt(string message)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                throw new FormatException("Input is not a valid integer.");
            }

            return result;
        }

        public static double ReadDouble(string message)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (!double.TryParse(input, out double result))
            {
                throw new FormatException("Input is not a valid double number.");
            }

            return result;
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

                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}