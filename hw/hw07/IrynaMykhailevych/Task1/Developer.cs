using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task1_IrynaMykhailevych
{
    internal class Developer : Staff
    {
        public string Level { get; set; } = "";

        public Developer(string name, decimal salary, string level) : base(name, salary)
        {
            this.Level = level;
        }

        public override void Print()
        {
            Console.WriteLine("Developer:");
            base.Print();
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Level: {Level}");
        }
    }
}
