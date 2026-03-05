using System;

namespace ConsoleApp1
{
    internal static class Task10
    {
        public static void Run()
        {
            Console.WriteLine("Task 10 — Contains only odd digits");

            int number = Math.Abs(InputHelper.ReadInt("Enter integer:"));

            bool onlyOdd = true;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    onlyOdd = false;
                    break;
                }

                number /= 10;
            }

            if (number == 0 || onlyOdd == false)
            {
                ConsoleHelper.WriteError("Not only odds");
                InputHelper.PrintSeparator();
                return;
            }
            else
            {
                Console.WriteLine($"Contains only odd digits: {onlyOdd}");
                InputHelper.completedTasks++;
            }
            InputHelper.PrintSeparator();
        }
    }
}