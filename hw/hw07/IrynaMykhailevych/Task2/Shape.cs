using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task2_IrynaMykhailevych
{
    abstract class Shape : IComparable<Shape>
    {
        private string name; 

        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }   

        public Shape(string name)
        {
            Name = name; 
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}
