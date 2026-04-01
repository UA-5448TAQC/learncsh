using System;

namespace HorlovaSofiia
{
    internal class ProgramTask6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Enter a valid name:");
                name = Console.ReadLine();
            }

            int age = ReadInt($"How old are you, {name}?");

            Console.WriteLine($"Your name is {name} and you are {age} years old.");
        }

        private static int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("Enter a valid positive integer.");
            }
        }
    }
}