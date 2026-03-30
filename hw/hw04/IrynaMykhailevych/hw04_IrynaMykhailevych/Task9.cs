using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task9
    {
        public static void Run()
        {
            int sum = 0;
            int digit;
            int number = ReadInt("Enter a number: ");
            number = Math.Abs(number);

            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number = number / 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Try again:");
                input = Console.ReadLine();
            }

            return result;
        }
    }
}
