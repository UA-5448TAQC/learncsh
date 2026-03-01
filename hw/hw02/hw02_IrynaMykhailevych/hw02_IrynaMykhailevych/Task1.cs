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
        static void Main(string[] args)
        {

            int a;
            int b;

            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());

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

            Console.ReadLine();

        }
    }
}
