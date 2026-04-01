namespace MaxAndMinOfIntegers;

internal class Program
{
    static void Main(string[] args)
    {
        int firstInteger = EnterIntegerValue("first");
        int secondInteger = EnterIntegerValue("second");
        int thirdInteger = EnterIntegerValue("third");

        int max = Math.Max(firstInteger, Math.Max(secondInteger, thirdInteger));
        int min = Math.Min(firstInteger, Math.Min(secondInteger, thirdInteger));

        Console.WriteLine("Maximum value: " + max);
        Console.WriteLine("Minimum value: " + min);
    }

    private static int EnterIntegerValue(string position)
    {
        do
        {
            Console.WriteLine($"Enter the {position} number:");

            if (Int32.TryParse(Console.ReadLine() ?? string.Empty, out int result))
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }
        while (true);
    }
}
