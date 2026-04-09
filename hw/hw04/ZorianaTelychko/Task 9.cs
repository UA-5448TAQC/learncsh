using System;
using System.Collections.Generic;
using System.Text;

namespace hw4_Zoriana_Telychko
{
    internal class Task_9
    {

        /* Find the sum of digits of the entered integer number.Example: 365 → 3 + 6 + 5 = 14 */

        static void Main()
        {
            Console.Write("Enter an integer number: ");
            string user_input = Console.ReadLine();
            if (int.TryParse(user_input, out int number)) 
            {
                int sum_of_digits = 0;
                int number_for_calculation = Math.Abs(number); // Handle negative numbers
                while (number_for_calculation > 0)
                {
                    sum_of_digits += number_for_calculation % 10; // Add the last digit to the sum
                    number_for_calculation /= 10; // Remove the last digit
                }
                Console.WriteLine($"The sum of the digits of {number} is: {sum_of_digits}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }
        }
    }
}
