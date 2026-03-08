using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04.Helpers
{
    internal class ProgramHelpers
    {
        public void EndOfTask()
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====Task Completed====");
            Console.ResetColor();
        }
    }
}
