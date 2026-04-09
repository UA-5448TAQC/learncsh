using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace hw4_Zoriana_Telychko
{
    // Enter 10 integer numbers.
    // If the first 5 numbers are all positive, calculate their sum.
    // Otherwise, calculate the product of the last 5 numbers.

    internal class Task_3
    {
        static void Main()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integer numbers: ");

            for (int i = 0; i < 10; i++) // Loop to read 10 integer numbers from the user
            {
                Console.WriteLine($"number {i + 1}: "); 
                string input = Console.ReadLine();
                while (!int.TryParse(input, out numbers[i])) // Validate that the input is an integer
                {
                    Console.WriteLine("Invalid input. Please enter an integer number: ");
                    input = Console.ReadLine();
                }

            }

            bool isAllPositive = true;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0) // Check if any of the first 5 numbers is not positive
                {
                    isAllPositive = false; // If found a non-positive number, set the flag to false
                    break; 
                }
            }

            
            if (isAllPositive)
            {
                int sum_first5 = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum_first5 += numbers[i]; 
                }
                Console.WriteLine($"The sum of the first 5 numbers is: {sum_first5}"); // Output the sum of the first 5 numbers
            }
             else
            {
                long product_last5 = 1;
                for (int i = 5; i < 10; i++)
                {
                    product_last5 *= numbers[i]; 
                }
                Console.WriteLine($"The product of the last 5 numbers is: {product_last5}"); // Output the product of the last 5 numbers
            }
        }
    }
}
