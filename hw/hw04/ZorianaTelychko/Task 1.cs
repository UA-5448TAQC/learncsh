using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw4_Zoriana_Telychko
{

    // Read a string str. Calculate the number of characters:'a','o' 'i' 'e'. (Uppercase letters should also be counted.)
    internal class Task_1
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            int count_a = 0;
            int count_o = 0;
            int count_i = 0;
            int count_e = 0;

            foreach (char c in userInput)
            {
                if (c == 'a' || c == 'A')
                {
                    count_a++;
                }

                if (c == 'o' || c == 'O')
                {
                    count_o++;
                }
                if (c == 'i' || c == 'I')
                {
                    count_i++;
                }
                if (c == 'e' || c == 'E')
                {
                    count_e++;
                }

            }
            Console.WriteLine($"'a' found: {count_a} times");
            Console.WriteLine($"'o' found: {count_o} times");
            Console.WriteLine($"'i' found: {count_i} times");
            Console.WriteLine($"'e' found: {count_e} times");

        }

    }
}
