namespace Task3
{
    internal class Program
    {
        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            int number;

            // чи це число
            if (!int.TryParse(input, out number))
            {
                throw new FormatException("Not a number!");
            }

            // діапазон
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException($"Number must be between {start} and {end}");
            }

            return number;
        }
        static void Main()
        {
            int start = 1;
            int end = 100;

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Enter number {i + 1}: ");

                        int num = ReadNumber(start, end);

                        numbers[i] = num;

                        start = num;

                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message)");
                    }
                }
            }

            Console.WriteLine("\nAll numbers are valid:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
