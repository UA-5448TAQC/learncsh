namespace Task9;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        int number = ReadInteger();
        int sum = CalculateDigitSum(number);

        Console.WriteLine($"Sum of digits: {sum}");
    }

    private static int ReadInteger()
    {
        while (true)
        {
            Console.Write("Enter an integer number: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static int CalculateDigitSum(int number)
    {
        number = Math.Abs(number);
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
