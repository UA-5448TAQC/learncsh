using System;

namespace hw3_Zoriana_Telychko
{
    internal class Task1
    {
        private static void Main(string[] args)
        {
            // Read 3 float numbers and check if they are all in the range [-5.5].

            Console.WriteLine("Enter three numbers to check if they are in range [-5, 5]:");

            Console.Write("Number 1: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.Write("Number 3: ");
            float n3 = float.Parse(Console.ReadLine());

            // 2. Define the range boundaries
            float min = -5.0f; //f Suffix: -5.0f - to tell the compiler specifically that it is a float.
            float max = 5.0f;

            bool allInRange = (n1 >= min && n1 <= max) &&
                              (n2 >= min && n2 <= max) &&
                              (n3 >= min && n3 <= max);

            if (allInRange)
            {
                Console.WriteLine("All numbers are within the range [-5, 5].");
            }
            else
            {
                Console.WriteLine("One or more numbers are outside the range [-5, 5].");
            }
        }
    }
}