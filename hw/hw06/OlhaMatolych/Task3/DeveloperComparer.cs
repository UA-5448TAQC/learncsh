using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DeveloperComparer : IComparer<IDeveloper>
    {
        public int Compare(IDeveloper? x, IDeveloper? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;    

            return x.Tool.CompareTo(y.Tool);
        }
    }
}
