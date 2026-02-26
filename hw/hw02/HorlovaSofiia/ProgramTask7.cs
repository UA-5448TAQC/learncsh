using System;

namespace HorlovaSofiia
{
    internal class ProgramTask7
    {
        static void Main(string[] args)
        {
            double radius = ReadDouble("Enter radius of the circle:");

            double length = 2.0 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            double volume = 4.0 / 3.0 * Math.PI * radius * radius * radius;

            Console.WriteLine($"Length of the circle = {length:F2}");
            Console.WriteLine($"Area of the circle = {area:F2}");
            Console.WriteLine($"Volume of the sphere = {volume:F2}");
        }

        private static double ReadDouble(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (double.TryParse(input, out double result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("Enter a valid positive number.");
            }
        }
    }
}