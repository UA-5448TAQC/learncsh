using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task1_IrynaMykhailevych
{
    internal class Person
    {
        public string Name { get; set; } = "";

        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void Print() 
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
