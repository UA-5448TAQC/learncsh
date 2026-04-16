using System;

namespace Task1
{
    public class Developer : Staff
    {
        private string level;

        public Developer(string name, string level, decimal salary)
            : base(name, salary)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine("Developer: " + Name + ", Level: " + level + ", Salary: " + Salary);
        }

        public override string ToString()
        {
            return "Developer: " + Name + ", Level: " + level + ", Salary: " + Salary;
        }
    }
}