using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of a circle:");
            double radius;

            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius:");
            }

            double pi = Math.PI;

            double length = 2 * pi * radius;
            double area = pi * radius * radius;
            double volume = 4 / 3 * pi * radius * radius * radius;

            Console.WriteLine($"The length is {length:F2}");
            Console.WriteLine($"The area is {area:F2}");
            Console.WriteLine($"The volume is {volume:F2}");
        }
    }
}