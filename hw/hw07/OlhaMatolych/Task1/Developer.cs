using System;

namespace ConsoleApp1
{
    internal class Developer : Staff
    {
        public string Level { get; set; }

        public Developer(string name, string level, decimal salary) : base(name, salary)
        {
            Level = level;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Developer: Name = {Name}, Level = {Level}, Salary = {Salary}";
        }
    }
}