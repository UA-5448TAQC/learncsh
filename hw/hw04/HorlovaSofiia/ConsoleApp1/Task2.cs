using System;

namespace ConsoleApp1
{
    internal static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Task 2 — Days in month");

            int month = InputHelper.ReadIntRange("Enter month number (1–12):", 1, 12);       

            int days = month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => 0
            };

                ConsoleHelper.WriteSuccess($"Days in month: {days}");
                InputHelper.completedTasks++;

            InputHelper.PrintSeparator();
        }
    }
}