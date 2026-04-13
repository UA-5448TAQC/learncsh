using System;
namespace ConsoleApp1
{ 
    internal class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Name = string.Empty;
        }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Person: Name = {Name}");
        }

        public override string ToString()
        {
            return $"Person: Name = {Name}";
        }
    }
}