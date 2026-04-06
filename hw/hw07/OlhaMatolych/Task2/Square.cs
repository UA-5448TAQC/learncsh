namespace ConsoleApp1
{
    internal class Square : Shape
    {
        public double Side { get; set; }

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