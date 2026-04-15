using System;

namespace ConsoleApp1
{
    internal static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Task 2 — Throwing Custom Exception");

            try
            {
                double a = InputHelper.ReadDouble("Enter first double:");
                double b = InputHelper.ReadDouble("Enter second double:");

                double result = MathService.DivideDouble(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivisionByZeroCustomException ex)
            {
                Console.WriteLine($"Custom exception: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                InputHelper.PrintSeparator();
            }
        }
    }
}