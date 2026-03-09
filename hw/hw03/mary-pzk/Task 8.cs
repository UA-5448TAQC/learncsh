namespace HW_3
{
    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }
    internal class Task_8
    {
        static void Main(string[] args)
        {
            TestCaseStatus test1Status;
            test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
        }
    }
}