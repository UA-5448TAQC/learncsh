namespace BooleanExpression;

internal class Program
{
    static void Main(string[] args)
    {
        int firstInt = EnterIntValue("first");
        int secondInt = EnterIntValue("second");

        bool arePositive = firstInt > 0 && secondInt > 0;
        Console.WriteLine($"Both numbers are positive: {arePositive}");
    }

    private static int EnterIntValue(string position)
    {
        do
        {
            Console.WriteLine($"Enter the {position} number:");

            string input = Console.ReadLine() ?? string.Empty;
            bool result = Int32.TryParse(input, out int c);

            if (result)
            {
                return c;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        while (true);
    }
}
