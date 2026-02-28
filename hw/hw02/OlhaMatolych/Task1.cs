using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            while (true)
            {
                Console.WriteLine("Specify first number:");

                if (int.TryParse(Console.ReadLine(), out a))
                    break;

                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }

            while (true)
                {
                Console.WriteLine("Specify second number:");

                if (int.TryParse(Console.ReadLine(), out b))
                     break;

                    Console.WriteLine("Invalid input. Please enter a valid integer number.");
                }

                Console.WriteLine("a + b = " + (a + b));
                Console.WriteLine("a - b = " + (a - b));
                Console.WriteLine("a * b = " + (a * b));

                if (b != 0)
                    Console.WriteLine("a / b = " + (a / b));
                else
                    Console.WriteLine("Division by zero is not allowed.");
        }
    }
}