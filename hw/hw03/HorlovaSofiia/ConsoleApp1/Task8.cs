using System;

namespace ConsoleApp1
{
    internal static class Task8
    {
        public static void Run()
        {
            Console.WriteLine("Task 8 — Test Case Status Enum");

            TestCaseStatus test1Status = TestCaseStatus.Pass;

            Console.WriteLine($"test1Status = {test1Status}");
            InputHelper.PrintSeparator();
        }

        private enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }
    }
}