using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first character:");
            char ch1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second character:");
            char ch2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third character:");
            char ch3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"You entered {ch1}, {ch2}, {ch3}.");

        }
    }
}