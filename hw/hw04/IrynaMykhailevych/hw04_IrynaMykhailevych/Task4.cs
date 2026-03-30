using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task4
    {
        public static void Run() 
        { 
            int a = ReadInt("Enter a number 1: ");
            int b = ReadInt("Enter a number 2: ");

            int count = 0;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
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
