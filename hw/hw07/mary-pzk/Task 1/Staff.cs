using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW07
{
    public class Staff : Person
    {
        private int salary;

        public int Salary { get { return salary; } }

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Staff member: {Name}. Salary: {Salary}.";
        }
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
    