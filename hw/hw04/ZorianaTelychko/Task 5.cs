using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace hw4_Zoriana_Telychko
{
    internal class Task_5
    {
        // Enter a string text. Print every second character of the string. Example: Hello → el

        static void Main()
        {

            Console.WriteLine("Enter some text: ");
            string user_input = Console.ReadLine();

            Console.Write($"every second character of the string -> ");

            for (int i = 1; i < user_input.Length; i += 2) 
            {
                Console.Write(user_input[i]);
            }
            
        }
    }
}
