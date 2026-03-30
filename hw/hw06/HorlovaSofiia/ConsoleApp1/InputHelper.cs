using System;
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

                Console.WriteLine("Invalid integer. Try again.");
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

                Console.WriteLine($"Value must be >= {minValue}. Try again.");
            }
        }

        public static uint ReadUInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (uint.TryParse(input, out uint result))
                {
                    return result;
                }

                Console.WriteLine("Invalid unsigned integer. Try again.");
            }
        }

        public static bool ReadBool(string message)
        {
            while (true)
            {
                Console.WriteLine(message + " (true/false)");
                string? input = Console.ReadLine();

                if (bool.TryParse(input, out bool result))
                {
                    return result;
                }

                Console.WriteLine("Enter true or false.");
            }
        }
    }
}