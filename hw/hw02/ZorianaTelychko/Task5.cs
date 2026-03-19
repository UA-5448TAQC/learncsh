using System;
using System.Reflection.Metadata;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task5
    {
        private static void Main(string[] args)
        // 5 - Define integer variable a (side of the square).
        // Read value from the console and calculate the area and perimeter of a square with length a.Output results on the console.


        { 
            Console.Write("Enter the length of the square's side: ");
            int side = int.Parse(Console.ReadLine());

            int perimeter = 4 * side;
            int area = side * side;

            Console.WriteLine($"Side Length: {side}");
            Console.WriteLine($"Perimeter:   {perimeter}");
            Console.WriteLine($"Area:        {area}");
        }
    }
}
