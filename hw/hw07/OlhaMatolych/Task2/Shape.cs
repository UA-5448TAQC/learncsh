using System;

namespace ConsoleApp1
{
    internal abstract class Shape : IComparable<Shape>
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}