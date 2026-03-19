using System;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task2
    {
        private static void Main(string[] args)
        // 2 - Output question “How are you?“.Define string variable answer.Read value answer and output on the console: “You are (answer)".

        {
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}.");
        }
    }
}
