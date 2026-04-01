using System;

namespace HorlovaSofiia
{
    internal class ProgramTask3
    {
        static void Main(string[] args)
        {
            char first = ReadChar("Enter first char:");
            char second = ReadChar("Enter second char:");
            char third = ReadChar("Enter third char:");

            Console.WriteLine($"You entered {first}, {second}, {third}");
        }

        private static char ReadChar(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) && input.Length == 1)
                {
                    return input[0];
                }

                Console.WriteLine("Enter one character each.");
            }
        }
    }
}