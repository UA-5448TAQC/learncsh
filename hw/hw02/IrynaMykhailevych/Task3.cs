using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw02_IrynaMykhailevych
{
    internal class Task3
    {
        static void Main()
        {
            char firstChar = ReadChar("Enter first char:");
            char secondChar = ReadChar("Enter second char:");
            char thirdChar = ReadChar("Enter third char:");

            Console.WriteLine("You entered: " + firstChar + ", " + secondChar + ", " + thirdChar);
        }


        static char ReadChar(string messageForUser)
        {
            Console.WriteLine(messageForUser);

            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a valid character:");
                input = Console.ReadLine();
            }

            return input[0];
        }
    }
}