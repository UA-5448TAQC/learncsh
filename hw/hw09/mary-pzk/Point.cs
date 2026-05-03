using System;

namespace HW09
{
    public readonly struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point other)
            {
                return X == other.X && Y == other.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
