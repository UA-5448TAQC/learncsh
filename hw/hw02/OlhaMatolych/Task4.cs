using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first integer number:");
            int int1;
           
            while (!int.TryParse(Console.ReadLine(), out int1))
            {
                Console.WriteLine("Invalid input. Please enter a whole number (no decimals).");
            }

            Console.WriteLine("Please enter second integer number:");
            int int2;

            while (!int.TryParse(Console.ReadLine(), out int2))
            {
                Console.WriteLine("Invalid input. Please enter a whole number (no decimals).");
            }

            bool bothPositive = (int1 > 0 && int2 > 0);
            Console.WriteLine("Are both numbers positive? " + bothPositive);
        }
    }
}