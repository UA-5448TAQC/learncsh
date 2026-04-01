using System;

namespace HorlovaSofiia
{
    internal class ProgramTask4
    {
        static void Main(string[] args)
        {
            int firstNumber = ReadInt("Enter first integer:");
            int secondNumber = ReadInt("Enter second integer:");

            bool bothPositive = firstNumber > 0 && secondNumber > 0;

            Console.WriteLine($"Both numbers are positive: {bothPositive}");
        }

        private static int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                Console.WriteLine("Invalid number.");
            }
        }
    }
}