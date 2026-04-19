using System.Collections;

namespace Task3
{
    internal class Program
    {
        static int ReadNumber(int start, int end)
        {

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new FormatException($"Input is not a number.");
            }

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException($"Number must be between {start} and {end}.");
            }
            return number;
        }
        static void Main(string[] args)
        {

            int[] num = new int[10];
            int previous = 1;

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        int numbersLeft = num.Length - i - 1;
                        int start = previous + 1;
                        int end = 99 - numbersLeft;

                        Console.Write($"Enter number {i + 1} in range [{start}-{end}]: ");

                        num[i] = ReadNumber(start, end);
                        previous = num[i];

                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
          
            }
            Console.WriteLine("\nEntered numbers:");
            foreach (int number in num)
            {
                Console.WriteLine(number);
            }
        }
    }
}
