using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw4_Zoriana_Telychko
{
    internal class Task_4
    {

        // Enter two integers a and b.Calculate how many integers in range[a..b] are divisible by 3 without remainder.
        // Example:1..10 → 3  (3, 6, 9)
        static void Main()
        {
            int[] numbers = new int[2];
            Console.WriteLine("Enter 2 integer numbers: ");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"number {i + 1}: ");
                string input = Console.ReadLine();
                while (!int.TryParse(input, out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer number: ");
                    input = Console.ReadLine();
                }
            }

            int start = Math.Min(numbers[0], numbers[1]);
            int end = Math.Max(numbers[0], numbers[1]);

            int count = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine($"The number of integers in the range [{start}..{end}] that are divisible by 3 without remainder is: {count}");
        }

    }
}
