using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task10
    {
        public static void Run() 
        {
            int number = ReadInt("Enter a number: ");
            number = Math.Abs(number);
            bool onlyOdd = true;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    onlyOdd = false;
                    break;
                }
                number = number / 10;
            }
            Console.WriteLine(onlyOdd);
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
