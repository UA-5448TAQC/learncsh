using System;

namespace HW06
{
    interface IDeveloper : IComparable
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
