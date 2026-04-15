using System;

namespace hw10_Task3_IrynaMykhailevych
{
    internal class Program
    {
        static void Run()
        {
            Student student = new Student("John Doe");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            student.MarkChange += parent.OnMarkChange;

            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(11);
            student.AddMark(9);
        }
    }
}
