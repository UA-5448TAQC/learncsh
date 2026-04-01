namespace Task4;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        int a = ReadInteger("Enter integer a: ");
        int b = ReadInteger("Enter integer b: ");

        (a, b) = EnsureOrder(a, b);

        int count = CountDivisibleByThree(a, b);

        Console.WriteLine($"Count of numbers divisible by 3: {count}");
    }

    private static int ReadInteger(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static (int, int) EnsureOrder(int a, int b)
    {
        if (a > b)
        {
            (b, a) = (a, b);
        }
        return (a, b);
    }

    private static int CountDivisibleByThree(int start, int end)
    {
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
