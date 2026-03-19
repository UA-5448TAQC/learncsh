using System;

namespace ConsoleApp1
{
    internal static class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Task 3 — 10 integers (sum first 5 if all positive, else product last 5)");

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = InputHelper.ReadInt($"Enter integer #{i + 1}:");
            }

            bool firstFivePositive = true;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    firstFivePositive = false;
                    break;
                }
            }

            if (firstFivePositive)
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += numbers[i];
                }

                ConsoleHelper.WriteSuccess($"Sum of first 5: {sum}");
                InputHelper.completedTasks++;
            }
            else
            {
                int product = 1;
                for (int i = 5; i < 10; i++)
                {
                    product *= numbers[i];
                }

                ConsoleHelper.WriteError($"Product of last 5: {product}");
            }

            InputHelper.PrintSeparator();
        }
    }
}