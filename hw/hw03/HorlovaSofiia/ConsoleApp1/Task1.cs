using System;
using ConsoleAppTasks.Infrastructure;

namespace ConsoleAppTasks.Tasks
{
    internal static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Task 1 — Float Numbers in Range [-5; 5]");

            float a = InputHelper.ReadFloat("Enter first float number:");
            float b = InputHelper.ReadFloat("Enter second float number:");
            float c = InputHelper.ReadFloat("Enter third float number:");

            bool inRange = IsInRange(a) && IsInRange(b) && IsInRange(c);

            Console.WriteLine($"All numbers are in range [-5; 5]: {inRange}");
            InputHelper.PrintSeparator();
        }

        private static bool IsInRange(float value)
        {
            return value >= -5f && value <= 5f;
        }
    }
}