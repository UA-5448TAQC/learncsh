using System;

namespace ConsoleApp1
{
    internal class Teacher : Staff
    {
        public string Subject { get; set; }

        public Teacher(string name, string subject, decimal salary) : base(name, salary)
        {
            Subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Teacher: Name = {Name}, Subject = {Subject}, Salary = {Salary}";
        }
    }
}