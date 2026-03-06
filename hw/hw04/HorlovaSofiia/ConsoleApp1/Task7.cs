using ConsoleApp1;

namespace ConsoleApp1
{
    internal static class Task7
    {
        public static void Run()
        {
            Console.WriteLine("Task 7 — Average of positives (stop on first negative)");

            int sum = 0;
            int count = 0;

            while (true)
            {
                int number = InputHelper.ReadInt("Enter positive integer:");

                if (number < 0)
                {
                    break;
                }

                sum += number;
                count++;
            }

            if (count == 0)
            {
                ConsoleHelper.WriteError("It's 0...");
                InputHelper.PrintSeparator();
                return;
            }
            else
            {
                double average = (double)sum / count;
                ConsoleHelper.WriteSuccess($"Average: {average:F2}");
                InputHelper.completedTasks++;
            }
            InputHelper.PrintSeparator();
        }
    }
}