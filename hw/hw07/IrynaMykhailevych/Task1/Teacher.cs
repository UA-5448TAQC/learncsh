using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task1_IrynaMykhailevych
{
    internal class Teacher : Staff
    {
        public string Subject { get; set; } = "";

        public Teacher(string name, decimal salary, string subject) : base(name, salary)
        {
            this.Subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine("Teacher:");
            base.Print();
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}
