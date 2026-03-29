namespace Task7;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        (int sum, int count) = ReadAndProcessNumbers();

        PrintAverage(sum, count);
    }

    private static (int sum, int count) ReadAndProcessNumbers()
    {
        int sum = 0;
        int count = 0;

        while (true)
        {
            Console.Write("Enter a positive integer (negative to stop): ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            if (number < 0)
            {
                break;
            }

            if (number > 0)
            {
                sum += number;
                count++;
            }
        }

        return (sum, count);
    }

    private static void PrintAverage(int sum, int count)
    {
        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"Arithmetic average: {average}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }
    }
}
