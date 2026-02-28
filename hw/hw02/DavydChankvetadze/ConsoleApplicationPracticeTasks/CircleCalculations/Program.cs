namespace CircleCalculations;

internal class Program
{
    static void Main(string[] args)
    {
        double circleRadius = EnterIntValue();
        
        Console.WriteLine($"Length: {2 * Math.PI * circleRadius}");
        Console.WriteLine($"Area: {Math.PI * circleRadius * circleRadius}");
        Console.WriteLine($"Volume: {4/3 * Math.PI * circleRadius * circleRadius * circleRadius}");
    }

    private static double EnterIntValue()
    {
        do
        {
            Console.WriteLine($"Enter a radius of a circle:");

            string input = Console.ReadLine() ?? string.Empty;
            bool result = Double.TryParse(input, out double c);

            if (result && c > 0)
            {
                return c;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        while (true);
    }
}
