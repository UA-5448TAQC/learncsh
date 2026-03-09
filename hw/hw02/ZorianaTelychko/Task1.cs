using System;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task1
    {
        private static void Main(string[] args)
        {

            // Task 1
            // 1 - Define integer variables a and b.
            // Read values a and b from the console and calculate: a + b, a - b, a * b, a/b.
            // Output results on the console

            {
                Console.Write("Enter value for a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter value for b: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Sum:          {a + b}");
                Console.WriteLine($"Difference:   {a - b}");
                Console.WriteLine($"Product:      {a * b}");

                // Check if b is zero before dividing
                if (b != 0)
                {
                    // Cast 'a' to (double) so the result includes decimals
                    double quotient = (double)a / b;
                    // (double)a - explicit casting. It momentarily tells the computer, "Treat $a$ as a decimal number just for this calculation"
                    Console.WriteLine($"Quotient: {quotient}");
                }
                else
                {
                    Console.WriteLine("Quotient:       Error (Cannot divide by zero!)");
                }
            }
        }
    }
}


