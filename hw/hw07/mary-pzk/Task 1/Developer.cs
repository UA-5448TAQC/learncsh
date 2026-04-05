using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW07
{
    public class Developer : Staff
    {
        private string level;

        public Developer(string name, string level, int salary) : base(name, salary)
        {
            this.level = level;
        }

        public override string ToString()
        {
            return $"Developer {Name} is a {level} developer. Salary: {Salary}.";
        }
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
