using System;

namespace ConsoleApp1
{
    internal static class Task9
    {
        public static void Run()
        {
            Console.WriteLine("Task 9 — Sum of digits");

            int number = Math.Abs(InputHelper.ReadInt("Enter integer:"));
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            ConsoleHelper.WriteSuccess($"Sum of digits: {sum}");
            InputHelper.completedTasks++;
            InputHelper.PrintSeparator();
        }
    }
}