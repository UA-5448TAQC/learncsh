namespace Task10;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        int number = ReadInteger();
        bool result = HasOnlyOddDigits(number);

        Console.WriteLine(result);
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

    private static bool HasOnlyOddDigits(int number)
    {
        number = Math.Abs(number);

        if (number == 0)
        {
            return false;
        }

        while (number > 0)
        {
            int digit = number % 10;

            if (digit % 2 == 0)
            {
                return false;
            }

            number /= 10;
        }

        return true;
    }
}