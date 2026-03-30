using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task7
    {
        public static void Run()
        {
            int sum = 0;
            int count = 0;
            int number;

            do
            {
                number = ReadInt("Enter a number: ");

                if (number >= 0) 
                {
                    sum += number;
                    count++;
                }

            } while (number >= 0);

            if (count == 0)
            {
                Console.WriteLine("No positive numbers entered.");
            }
            else
            {
                double average = (double)sum / count;
                Console.WriteLine("Average value of positive numbers: " + average);
            }
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
