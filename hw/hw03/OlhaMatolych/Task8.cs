
namespace ConsoleApp1
{
    class Program
    {
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }
        static void Main()
        {
            TestCaseStatus test1Status = TestCaseStatus.Pass;

            Console.WriteLine("Test 1 Status: " + test1Status);
        }
    }
}