using System;

namespace ConsoleApp1
{
    internal class Staff : Person
    {
        public decimal Salary { get; set; }

        public Staff()
        {
            Salary = 0;
        }

        public Staff(string name, decimal salary)
            : base(name)
        {
            Salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Staff: Name = {Name}, Salary = {Salary}");
        }

        public override string ToString()
        {
            return $"Staff: Name = {Name}, Salary = {Salary}";
        }
    }
}