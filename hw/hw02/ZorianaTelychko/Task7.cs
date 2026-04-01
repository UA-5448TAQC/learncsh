using System;
using System.Reflection.Metadata;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task7
    {
        private static void Main(string[] args)
        // 7 - Read double number r (radius of a circle).
        // Calculate the length(l = 2 * pi * r), area (S = pi * r * r), and volume(4/3*pi* r*r* r) of a circle.

        {
            Console.Write("Enter the radius: ");
            double r = double.Parse(Console.ReadLine());

            double length = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            double volume = 4 / 3 * Math.PI * r * r * r;

            Console.WriteLine($"Length (L): {length:F2}"); // :F2 rounds to 2 decimal places
            Console.WriteLine($"Area (S):   {area:F2}");
            Console.WriteLine($"Volume (V): {volume:F2}");
        }
    }
}
