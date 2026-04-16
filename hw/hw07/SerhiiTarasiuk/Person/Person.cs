using System;

namespace Task1
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine("Person: " + Name);
        }

        public override string ToString()
        {
            return "Person: " + Name;
        }
    }
}