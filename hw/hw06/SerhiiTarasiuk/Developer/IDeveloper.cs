using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public interface IDeveloper
    {
        string Tool { get; }
        void Create();
        void Destroy();
    }
}
