using System;

namespace ConsoleApp1
{
    internal static class Task8
    {
        public static void Run()
        {
            Console.WriteLine("Task 8 — Leap year check");

            int year = InputHelper.ReadInt("Enter year:");

            bool isLeap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

            if (isLeap)
            {
                ConsoleHelper.WriteSuccess("A leap year yaaay");
                InputHelper.completedTasks++;
            }
            else
            {
                ConsoleHelper.WriteError("Nope");
            }

            InputHelper.PrintSeparator();
        }
    }
}