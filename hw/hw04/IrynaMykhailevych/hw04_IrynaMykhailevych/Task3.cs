using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task3
    {
        public static void Run()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
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

                Console.WriteLine("The sum of the first five numbers: " + sum);
            }
            else
            {
                int product = 1;

                for (int i = 5; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }

                Console.WriteLine("The product of the last five numbers: " + product);
            }
        }
    }
}
