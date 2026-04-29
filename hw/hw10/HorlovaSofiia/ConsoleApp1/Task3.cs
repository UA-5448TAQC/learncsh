using System;

namespace ConsoleApp1
{
    internal static class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Task 3 — Delegates & Events");

            Student student = new Student("Sofiia");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(12);
            student.AddMark(8);
            student.AddMark(10);

            Console.WriteLine(new string('-', 60));
        }
    }
}