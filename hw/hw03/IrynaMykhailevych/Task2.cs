using System;

namespace hw03_IrynaMykhailevych
{
    internal class Task2
    {
        public static void Run()
        {
            int value1 = ReadInt("Enter the first integer value: ");
            int value2 = ReadInt("Enter the second integer value: ");
            int value3 = ReadInt("Enter the third integer value: ");

            int max = MaxValue(value1, value2, value3);
            int min = MinValue(value1, value2, value3);

            PrintResult(max, min);
        }
        static int ReadInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter the valid value: ");
                input = Console.ReadLine();
            }
            return result;
        }
        static int MaxValue(int value1, int value2, int value3)
        {
            return Math.Max(value1, Math.Max(value2, value3));
        }
        static int MinValue(int value1, int value2, int value3)
        {
            return Math.Min(value1, Math.Min(value2, value3));
        }
        static void PrintResult(int max, int min)
        {
            Console.WriteLine($"The maximum value is: {max}");
            Console.WriteLine($"The minimum value is: {min}");
        }
    }
}
