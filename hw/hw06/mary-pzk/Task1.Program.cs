using System;

namespace HW06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> items = new List<IFlyable>()
            {
                new Bird("Penguin", false),
                new Bird("Ostrich", false),
                new Bird("Parrot", true),
                new Bird("Sparrow", true),
                new Plane("Boeing", 10000),
                new Plane("Airbus", 12000),
                new Plane("Cessna 172", 4000),
                new Plane("Concorde", 18000)
            };

            foreach (var item in items)
            {
                item.Fly();
            }
        }
    }
}
