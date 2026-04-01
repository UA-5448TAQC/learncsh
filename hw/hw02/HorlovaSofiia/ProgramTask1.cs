using System;

namespace HorlovaSofiia
{
    internal class ProgramTask1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer (a):");
            int a = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter second integer (b):");
            int b = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");

            if (b != 0)
            {
                Console.WriteLine($"a / b = {(double)a / b}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }
}