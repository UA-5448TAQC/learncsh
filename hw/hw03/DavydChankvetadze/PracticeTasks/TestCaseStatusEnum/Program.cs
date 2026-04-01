namespace TestCaseStatusEnum;

internal class Program
{
    private enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }

    static void Main(string[] args)
    {
        TestCaseStatus test1Status = TestCaseStatus.Pass;

        Console.WriteLine($"Test 1 Status: {test1Status}");

    }
}
