using System;

namespace ConsoleApp1
{
    internal static class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Task 4 — Count numbers divisible by 3 in [a..b]");

            int a = InputHelper.ReadInt("Enter a:");
            int b = InputHelper.ReadInt("Enter b:");

            if (a > b)
            {
                (a, b) = (b, a);
            }

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                ConsoleHelper.WriteSuccess($"Found {count} numbers divisible by 3.");
                InputHelper.completedTasks++;
            }
            else
                ConsoleHelper.WriteError("No numbers divisible by 3.");

            InputHelper.PrintSeparator();
        }
    }
}