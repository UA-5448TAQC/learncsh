using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07
{
    public abstract class Shape : IComparable
    {
        private string name;
        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(object obj)
        {
            Shape other = (Shape)obj;

            if (this.Area() > other.Area())
                return 1;
            else if (this.Area() < other.Area())
                return -1;
            else
                return 0;
        }
    }
}
