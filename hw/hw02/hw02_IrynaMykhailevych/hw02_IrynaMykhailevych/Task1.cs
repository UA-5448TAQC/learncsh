using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw02_IrynaMykhailevych
{
    internal class Task1
    {
        static void Main()
        {

            int a = ReadInt("Enter a: ");
            int b = ReadInt("Enter b: ");

            CalculateAndPrintResults(a, b);

        }

        static int ReadInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please enter a valid integer:");
                input = Console.ReadLine();
            }

            return result;
        }
        
        static void CalculateAndPrintResults(int a, int b)
        {
            int sum = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine("Division: " + (a / (double)b));
            }
        }
    }
}
