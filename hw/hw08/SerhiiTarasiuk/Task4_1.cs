using System;

namespace Task3
{
    internal class Program
    {
              static void Main()
        {
            int[] numbers = new int[10];
            int previous = 1;

            for (int i = 0; i < 10; i++)
            {
                bool ok = false;

                while (!ok)
                {
                    try
                    {
                        Console.Write("Enter number a" + (i + 1) + " (" + (previous + 1) + "...99): ");
                        numbers[i] = ReadNumber(previous + 1, 99);
                        previous = numbers[i];
                        ok = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            Console.WriteLine("Numbers entered successfully:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int number;

            if (!int.TryParse(input, out number))
            {
                throw new FormatException("Input is not a number.");
            }

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }

            return number;
        }
    }
}