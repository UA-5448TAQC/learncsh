using System;

namespace Task1
{
    internal class Program
    {
        static int Div(int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter first integer: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int b = int.Parse(Console.ReadLine());

                int result = Div(a, b);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: division by zero.");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: invalid input format.");
                Console.ResetColor();
            }
        }
    }
}