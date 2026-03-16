using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();

            if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You are an empty shell, and it happens.");
            }
            else
            {
                Console.WriteLine("You are " + answer);
            }
        }
    }
}