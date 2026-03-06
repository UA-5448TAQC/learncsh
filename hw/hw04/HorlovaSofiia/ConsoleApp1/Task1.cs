using System;

namespace ConsoleApp1
{
    internal static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Task 1 — Count 'a', 'o', 'i', 'e' (case-insensitive)");

            string text = InputHelper.ReadNonEmptyString("Enter a string:");

            int count = 0;

            foreach (char c in text)
            {
                char lower = char.ToLower(c);

                if (lower == 'a' || lower == 'o' || lower == 'i' || lower == 'e')
                {
                    count++;
                }
            }

            if (count > 0)
            {
                ConsoleHelper.WriteSuccess($"Found {count} vowels.");
                InputHelper.completedTasks++;
            }
            else
                ConsoleHelper.WriteError("No vowels found.");

            InputHelper.PrintSeparator();
        }
    }
}