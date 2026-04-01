using System;

namespace ConsoleApp1
{
    internal class Developer : Staff
    {
        public string Level { get; set; }

        public Developer()
        {
            Level = string.Empty;
        }

        public Developer(string name, decimal salary, string level)
            : base(name, salary)
        {
            Level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"Developer: Name = {Name}, Salary = {Salary}, Level = {Level}");
        }

        public override string ToString()
        {
            return $"Developer: Name = {Name}, Salary = {Salary}, Level = {Level}";
        }
    }
}