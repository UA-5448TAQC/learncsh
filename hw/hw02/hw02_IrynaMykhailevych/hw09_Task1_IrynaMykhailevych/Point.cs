using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw09_Task1_IrynaMykhailevych
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
