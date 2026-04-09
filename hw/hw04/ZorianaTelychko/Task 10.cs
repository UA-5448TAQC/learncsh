using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw4_Zoriana_Telychko
{

    internal class Task_10
    {
        // Check if the entered integer number contains only odd digits.
        static void Main()
        {

            bool allOdd = true;

            Console.Write("Enter an integer number: ");
            string user_input = Console.ReadLine();
            if (int.TryParse(user_input, out int number))
            {
                int number_for_calculation = Math.Abs(number); // Handle negative numbers
                while (number_for_calculation > 0)
                {
                    int digit = number_for_calculation % 10;
                    if (digit % 2 == 0)
                    {
                        allOdd = false;
                        break;
                    }
                    else
                    {
                        number_for_calculation /= 10;
                    }
                }
                if (number == 0) allOdd = false;

                Console.WriteLine($"All digits in {number} are odd: {allOdd}");
            }
        }

    }
}
