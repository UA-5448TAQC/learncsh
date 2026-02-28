using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the side of the square:");
            int side;
           
            while (!int.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Invalid input. Please enter a whole number (no decimals).");
            }

            int area = side * side;
            int perimeter = 4 * side;

            Console.WriteLine("The area of a square is " + area);
            Console.WriteLine("The perimeter of a square is " + perimeter);
        }
    }
}