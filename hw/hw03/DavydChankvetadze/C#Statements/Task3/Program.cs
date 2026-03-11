namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out numbers[i]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        continue;
                    }
                    break;
                }
            }

            bool allPositive = true;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    allPositive = false;
                    break;
                }

            }

            if (allPositive)
            {
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine($"Sum of first 5 numbers: {sum}");
            }
            else
            {
                int product = 1;
                for (int i = 5; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }
                Console.WriteLine($"Product of last 5 numbers: {product}");
            }
        }
        }
}
