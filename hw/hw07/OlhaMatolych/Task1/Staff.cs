using System;

namespace ConsoleApp1
{
    internal class Staff : Person
    {
        public decimal Salary { get; set; }

        public Staff(string name, decimal salary) : base(name)
        {
            Salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Staff: Name = {Name}, Salary = {Salary}";
        }
    }
}