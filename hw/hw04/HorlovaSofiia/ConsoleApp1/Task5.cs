using System;

namespace ConsoleApp1
{
    internal static class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Task 5 — Print every second character");

            string text = InputHelper.ReadNonEmptyString("Enter text:");

            if (text.Length < 2)
            {
                ConsoleHelper.WriteError("Text too short.");
                InputHelper.PrintSeparator();
                return;
            }

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }

            InputHelper.completedTasks++;
            Console.WriteLine();
            InputHelper.PrintSeparator();
        }
    }
}