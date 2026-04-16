using System;

namespace Task2
{
    internal class Program
    {
        static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double b = double.Parse(Console.ReadLine());

                double result = Div(a, b);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: invalid input format.");
            }
        }
    }
}