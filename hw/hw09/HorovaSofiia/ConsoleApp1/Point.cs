using System;

namespace ConsoleApp1
{
    public readonly struct Point
    {
        private readonly double x;
        private readonly double y;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Point other)
        {
            double deltaX = other.X - X;
            double deltaY = other.Y - Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Point other)
            {
                return false;
            }

            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }
}