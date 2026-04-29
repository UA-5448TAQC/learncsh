using System;

namespace ConsoleApp1
{
    internal abstract class Shape : IComparable<Shape>
    {
        public string Name { get; set; }

        protected Shape()
        {
            Name = string.Empty;
        }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape? other)
        {
            if (other is null)
            {
                return 1;
            }

            return Area().CompareTo(other.Area());
        }

        public override string ToString()
        {
            return $"{GetType().Name}: Name = {Name}, Area = {Area():F2}, Perimeter = {Perimeter():F2}";
        }
    }
}