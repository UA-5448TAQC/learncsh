using System;

namespace ConsoleApp1
{
    internal abstract class Shape
    {
        public string Name { get; set; }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"{Name}, Area = {Area():F2}, Perimeter = {Perimeter():F2}";
        }
    }
}