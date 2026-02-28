namespace WorkingWithChar;

internal class Program
{
    static void Main(string[] args)
    {
        char firstChar = CharInput("first");
        char secondChar = CharInput("second");
        char thirdChar = CharInput("third");

        Console.WriteLine($"You entered {firstChar}, {secondChar}, {thirdChar}");
    }
    private static char CharInput(string position)
    {
        do
        {
            Console.WriteLine($"Enter the {position} char:");

            string input = Console.ReadLine() ?? string.Empty;

            if (input.Length == 1)
            {
                return input.First();
            }

            Console.WriteLine("Invalid input. Please enter a valid char.");
        }
        while (true);
    }
}
