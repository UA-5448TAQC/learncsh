using System;

namespace hw3_Zoriana_Telychko
{
    internal class Task2
    {
        private static void Main(string[] args)
        {
            {
                // Read 3 integer numbers and output max and min of them

                Console.WriteLine("Enter three integers:");

                Console.Write("n1: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("n2: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.Write("n3: ");
                int n3 = int.Parse(Console.ReadLine());

                // Find Max using Math.Max. Math.Max only compares two numbers at a time
                // Nesting: Math.Max(n1, Math.Max(n2, n3)). The computer solves the "inner" part first (comparing $n2$ and $n3$) and then compares that winner against $n1$
                int max = Math.Max(n1, Math.Max(n2, n3));
                int min = Math.Min(n1, Math.Min(n2, n3));

                Console.WriteLine($"The maximum number is: {max}");
                Console.WriteLine($"The minimum number is: {min}");
            }
        }
    }
}
