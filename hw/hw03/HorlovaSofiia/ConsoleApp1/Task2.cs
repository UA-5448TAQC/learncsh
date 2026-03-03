using System;
using ConsoleAppTasks.Infrastructure;

namespace ConsoleAppTasks.Tasks
{
    internal static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Task 2 — Max and Min of Integers");

            int x = InputHelper.ReadInt("Enter first integer:");
            int y = InputHelper.ReadInt("Enter second integer:");
            int z = InputHelper.ReadInt("Enter third integer:");

            int max = Math.Max(x, Math.Max(y, z));
            int min = Math.Min(x, Math.Min(y, z));

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
            InputHelper.PrintSeparator();
        }
    }
}