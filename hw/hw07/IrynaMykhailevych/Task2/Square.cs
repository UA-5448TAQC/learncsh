using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw07_Task2_IrynaMykhailevych
{
    internal class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}
