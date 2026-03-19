using System;

namespace ConsoleApp1
{
    internal static class Task9
    {
        public static void Run()
        {
            Console.WriteLine("Task 9 — Struct RGB");

            Rgb white = new Rgb(255, 255, 255);
            Rgb black = new Rgb(0, 0, 0);

            Console.WriteLine($"White: {white}");
            Console.WriteLine($"Black: {black}");
            InputHelper.PrintSeparator();
        }
    }
}