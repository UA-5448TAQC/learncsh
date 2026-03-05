using System;

namespace ConsoleApp1
{
    internal static class Task7
    {
        public static void Run()
        {
            Console.WriteLine("Task 7 — Greeting by Hour");

            int hour = InputHelper.ReadIntRange("Enter hour (0-23):", 0, 23);

            string greeting = hour switch
            {
                >= 6 and <= 11 => "Good morning!",
                >= 12 and <= 17 => "Good afternoon!",
                >= 18 and <= 22 => "Good evening!",
                _ => "Good night!"
            };

            Console.WriteLine(greeting);
            InputHelper.PrintSeparator();
        }
    }
}