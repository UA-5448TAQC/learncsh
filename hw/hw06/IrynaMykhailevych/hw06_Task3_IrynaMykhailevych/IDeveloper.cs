using System;

namespace hw06_Task3_IrynaMykhailevych
{
    internal interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
