using System;

namespace ConsoleApp1
{
    internal static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Task 1 — Division with Exception Handling");

            try
            {
                int a = InputHelper.ReadInt("Enter first integer:");
                int b = InputHelper.ReadInt("Enter second integer:");

                int result = MathService.Div(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero.");
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