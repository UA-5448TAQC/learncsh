using System.Transactions;

namespace ConsoleApp3
{

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
            Console.WriteLine("Task 8");
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"test1Status = {test1Status}");
        }
    }
}
