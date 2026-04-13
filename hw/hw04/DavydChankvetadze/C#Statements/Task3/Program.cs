namespace Task3;

internal class Program
{
    static void Main(string[] args)
    {

        int[] numbers = EnterIntegerValues(10);

        bool allPositive = AreAllPositive(numbers, 5);

        PrintResult(numbers, allPositive, 5);
    }

    private static int[] EnterIntegerValues(int count)
    {
        int[] numbers = new int[count];

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isParsed;
            do
            {
                Console.WriteLine($"Enter the {i + 1} number: ");
                isParsed = Int32.TryParse(Console.ReadLine() ?? string.Empty, out numbers[i]);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer number.");
                }
            }
            while (!isParsed);
        }

        return numbers;
    }

    private static bool AreAllPositive(int[] numbers, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (numbers[i] <= 0)
            {
                return false;
            }
        }
        return true;
    }

    private static void PrintResult(int[] numbers, bool allPositive, int count)
    {
        
        if (allPositive)
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Sum of first 5 numbers: {sum}");
        }
        else
        {
            int product = 1;
            for (int i = count; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine($"Product of last 5 numbers: {product}");
        }
    }
}
