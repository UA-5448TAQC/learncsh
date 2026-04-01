using System;

namespace HorlovaSofiia
{
    internal class ProgramTask5
    {
        static void Main(string[] args)
        {
            int side = ReadInt("Enter side of the square:");

            int area = side * side;
            int perimeter = 4 * side;

            Console.WriteLine($"Area of the square = {area}");
            Console.WriteLine($"Perimeter of the square = {perimeter}");
        }

        private static int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("Enter a valid positive integer.");
            }
        }
    }
}