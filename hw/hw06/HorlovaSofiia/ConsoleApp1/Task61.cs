using System.Collections.Generic;

namespace ConsoleApp1
{
    internal static class Task61
    {
        public static void Run()
        {
            Console.WriteLine("Homework 6.1 — Interface IFlyable");

            List<IFlyable> items = new List<IFlyable>
            {
                new Bird("Eagle", true),
                new Bird("Penguin", false),
                new Bird("Parrot", true),
                new Plane("Boeing", 10000),
                new Plane("Airbus", 12000)
            };

            foreach (IFlyable item in items)
            {
                item.Fly();
            }

            InputHelper.PrintSeparator();
        }
    }
}