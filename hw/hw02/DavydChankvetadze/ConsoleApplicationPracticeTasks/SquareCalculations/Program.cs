using System.Reflection.Metadata;

namespace SquareCalculations;

internal class Program
{
    static void Main(string[] args)
    {
        int squareSide = EnterIntValue();
        Console.WriteLine($"Area of the square: {squareSide*squareSide}");
        Console.WriteLine($"Perimeter of the square: {4 * squareSide}");
    }

    private static int EnterIntValue()
    {
        do
        {
            Console.WriteLine($"Enter the side of a square:");

            string input = Console.ReadLine() ?? string.Empty;
            bool result = Int32.TryParse(input, out int c);

            if (result && c > 0)
            {
                return c;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        while (true);
    }
}
