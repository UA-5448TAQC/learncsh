namespace ConsoleApp3
{
    internal class Program
    {
        public class NumberOutOfRangeException : Exception
        {
            public NumberOutOfRangeException(string message) : base(message)
            {
            }
        }
        static void Main(string[] args)
        {
            {
                int[] numbers = new int[10];
                int start = 1;
                int end = 100;

                Console.WriteLine("Enter 10 numbers such that:");
                Console.WriteLine("1 < a1 < a2 < ... < a10 < 100");

                for (int i = 0; i < numbers.Length; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Enter number a{i + 1}: ");
                            numbers[i] = ReadNumber(start, end);
                            start = numbers[i];
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Input is not a valid number.");
                        }
                        catch (NumberOutOfRangeException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Unexpected error: {ex.Message}");
                        }
                    }
                }
                Console.WriteLine("All numbers were entered correctly:");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
            static int ReadNumber(int start, int end)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int number))
                {
                    throw new FormatException("Input is not an integer.");
                }
                if (number <= start || number >= end)
                {
                    throw new NumberOutOfRangeException($"Number must be in range ({start}...{end}).");
                }
                return number;
            }
        }
    }
}