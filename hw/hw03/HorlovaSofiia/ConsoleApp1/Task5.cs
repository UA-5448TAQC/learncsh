using System;
using ConsoleAppTasks.Infrastructure;

namespace ConsoleAppTasks.Tasks
{
    internal static class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Task 5 — Valid Date Check (day & month)");

            int day = InputHelper.ReadInt("Enter day (integer):");
            int month = InputHelper.ReadInt("Enter month (integer):");

            bool isValid = IsValidDayMonth(day, month);

            Console.WriteLine($"Valid day/month: {isValid}");
            InputHelper.PrintSeparator();
        }

        private static bool IsValidDayMonth(int day, int month)
        {
            if (month < 1 || month > 12)
            {
                return false;
            }

            int daysInMonth = month switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => 0
            };

            return day >= 1 && day <= daysInMonth;
        }
    }
}