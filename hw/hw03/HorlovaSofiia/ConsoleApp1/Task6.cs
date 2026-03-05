using System;

namespace ConsoleApp1
{
    internal static class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Task 6 — Sum of First Two Digits After Decimal Point");

            decimal value = InputHelper.ReadDecimal("Enter a decimal number (e.g., 3.456):");
            decimal abs = Math.Abs(value);

            int firstDigit = (int)(abs * 10) % 10;
            int secondDigit = (int)(abs * 100) % 10;
            int sum = firstDigit + secondDigit;

            Console.WriteLine($"{firstDigit} + {secondDigit} = {sum}");
            InputHelper.PrintSeparator();
        }
    }
}