using System;
using System.Collections.Generic;

namespace HW06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>()
            {
                new Programmer("C#"),
                new Programmer("Python"),
                new Builder("Hammer"),
                new Builder("Drill")
            };

            foreach (var dev in developers)
            {
                dev.Create();
                dev.Destroy();
            }

            developers.Sort();

            Console.WriteLine("\nItems after ascending sorting:");

            foreach (var dev in developers)
            {
                Console.WriteLine(dev.Tool);
            }
        }
    }
}
