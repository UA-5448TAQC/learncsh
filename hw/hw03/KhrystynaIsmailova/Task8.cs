namespace Task8;

enum TestCaseStatus
{
    Pass,
    Fail,
    Blocked,
    WP,
    Unexecuted
}
internal class Program
    {
        static void Main(string[] args)
        {
        TestCaseStatus status = TestCaseStatus.Pass;
        Console.WriteLine(status);

    }
}