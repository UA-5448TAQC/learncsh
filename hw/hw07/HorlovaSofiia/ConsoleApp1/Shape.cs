using System;

namespace ConsoleApp1
{
    internal abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape? other)
        {
            if (other == null)
            {
                return 1;
            }

            return Area().CompareTo(other.Area());
        }

        public override string ToString()
        {
            return $"Name: {Name}, Area: {Area():F2}, Perimeter: {Perimeter():F2}";
        }
    }
}