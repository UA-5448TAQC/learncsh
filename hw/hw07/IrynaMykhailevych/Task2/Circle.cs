using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task2_IrynaMykhailevych
{
    internal class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area() 
        {
            return Math.PI * Radius * Radius; 
        }

        public override double Perimeter() 
        {
            return 2 * Math.PI * Radius;
        }
    }
}
