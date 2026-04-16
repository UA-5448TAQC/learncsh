using System;

namespace Task1
{
    public class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, string subject, decimal salary)
            : base(name, salary)
        {
            this.subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine("Teacher: " + Name + ", Subject: " + subject + ", Salary: " + Salary);
        }

        public override string ToString()
        {
            return "Teacher: " + Name + ", Subject: " + subject + ", Salary: " + Salary;
        }
    }
}