using System;

namespace ConsoleApp1
{
    internal class Teacher : Staff
    {
        public string Subject { get; set; }

        public Teacher()
        {
            Subject = string.Empty;
        }

        public Teacher(string name, decimal salary, string subject)
            : base(name, salary)
        {
            Subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine($"Teacher: Name = {Name}, Salary = {Salary}, Subject = {Subject}");
        }

        public override string ToString()
        {
            return $"Teacher: Name = {Name}, Salary = {Salary}, Subject = {Subject}";
        }
    }
}