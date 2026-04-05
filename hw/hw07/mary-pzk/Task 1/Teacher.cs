using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW07
{
    public class Teacher : Staff
    {
        private string subject;
        public Teacher(string name, string subject, int salary) : base(name, salary)
        {
            this.subject = subject;
        }

        public override string ToString()
        {
            return $"Teacher {Name} teaches {subject}. Salary: {Salary}.";
        }
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}

