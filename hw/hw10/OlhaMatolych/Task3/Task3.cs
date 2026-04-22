namespace Task3;

internal class Program
{
    static void Main()
    {
        Student student = new Student { Name = "Alice" };
        Parent parent = new Parent();
        Accountancy acc = new Accountancy();

        student.MarkChange += parent.OnMarkChange;
        student.MarkChange += acc.PayingFellowship;

        student.AddMark(85);
        student.AddMark(95);
    }
}