using System;

namespace Task1
{
    public class Staff : Person
    {
        public decimal Salary { get; set; }

        public Staff(string name, decimal salary)
            : base(name)
        {
            Salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine("Staff: " + Name + ", Salary: " + Salary);
        }

        public override string ToString()
        {
            return "Staff: " + Name + ", Salary: " + Salary;
        }
    }
}