using System;
using System.Collections.Generic;
using System.Text;

namespace hw3_Zoriana_Telychko
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
    //Identify enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted }.
    //Assign status “Pass” for variable test1Status and output result on the console

    {
        private static void Main(string[] args)
        {
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"Test case 1 status: {test1Status}");
        }
    }
}

