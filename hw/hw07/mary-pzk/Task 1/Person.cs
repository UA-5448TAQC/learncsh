using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW07
{

    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get { return name; } }

        public override string ToString()
        {
            return $"Person: {Name}.";
        }
        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
    