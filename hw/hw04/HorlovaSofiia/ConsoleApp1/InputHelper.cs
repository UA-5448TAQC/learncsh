using System;

namespace ConsoleApp1
{
    internal static class InputHelper
    {
        public static int completedTasks = 0;
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

                Console.WriteLine("Invalid integer. Try again.");
            }
        }

        public static int ReadIntRange(string message, int min, int max)
        {
            while (true)
            {
                int value = ReadInt(message);

                if (value >= min && value <= max)
                {
                    return value;
                }

                Console.WriteLine($"Value must be in range [{min}..{max}].");
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

                Console.WriteLine("Input cannot be empty. Try again.");
            }
        }
    }
}