using System;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task4
    {
        private static void Main(string[] args)
        // 4 - Enter 2 integer numbers. Check if they are both positive – use bool expression


        {
            Console.Write("Enter first number: ");
            int num_1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num_2 = int.Parse(Console.ReadLine());

            // bool var to store the resul
            bool bothPositive = (num_1 > 0) && (num_2 > 0);

            Console.WriteLine($"Are both numbers positive? {bothPositive}");
        }
    }
}
