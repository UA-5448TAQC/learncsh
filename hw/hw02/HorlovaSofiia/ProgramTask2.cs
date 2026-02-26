using System;

namespace HorlovaSofiia
{
    internal class ProgramTask2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you?");

            string answer = Console.ReadLine() ?? string.Empty;

            while (string.IsNullOrWhiteSpace(answer))
            {
                Console.WriteLine("Enter a valid answer:");
                answer = Console.ReadLine();
            }

            Console.WriteLine($"You are {answer}");
        }
    }
}