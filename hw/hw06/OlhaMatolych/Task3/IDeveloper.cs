using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal interface IDeveloper
        { 
        public string Tool { get; }
        void Create();
        void Destroy();
    }
}
