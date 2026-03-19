using System;

namespace hw03_IrynaMykhailevych
{
    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }
    internal class Task8
    {
        public static void Run()
        {
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
        }
    }
}
