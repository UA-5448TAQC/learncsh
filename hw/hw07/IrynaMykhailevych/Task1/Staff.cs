using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task1_IrynaMykhailevych
{
    internal class Staff : Person
    {
        public decimal Salary { get; set; }

        public Staff(string name, decimal salary) : base(name)
        {
            this.Salary = salary;
        }
    }
}
