namespace ConsoleApp1
{
    internal class Task_8
    {
        enum TestCaseStatus
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(test1Status);
            Console.ResetColor();
        }
    }
}
