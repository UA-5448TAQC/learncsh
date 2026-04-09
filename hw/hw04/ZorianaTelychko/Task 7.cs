using System;
using System.Collections.Generic;
using System.Text;

namespace hw4_Zoriana_Telychko
{
    internal class Task_7
    {
        static void Main()
        {
            double sum = 0;
            int count = 0;

            while (true) // Loop until the user enters a negative number or an invalid input

            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int number)) 
                {
                    Console.WriteLine("Invalid input. Stopping...");
                    break;
                }

                if (number < 0)
                {
                    break;
                }


                sum += number;
                count++;
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Sum: {sum}, Count: {count}, Average: {average}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }


        }
    }
}
