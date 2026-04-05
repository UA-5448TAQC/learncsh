using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius { get { return radius; } }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
