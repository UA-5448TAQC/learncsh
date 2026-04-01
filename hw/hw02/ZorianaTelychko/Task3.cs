using System;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task3
    {
        private static void Main(string[] args)
        // 3 - Read 3 variables of char type.
        // Write message: “You enter(first char), (second char), (3 char)”

        {
            Console.Write("Enter the first character: ");
            char first = char.Parse(Console.ReadLine());

            Console.Write("Enter the second character: ");
            char second = char.Parse(Console.ReadLine());

            Console.Write("Enter the third character: ");
            char third = char.Parse(Console.ReadLine());

            // interpolation
            Console.WriteLine($"You entered {first}, {second}, {third}");
        }
    }
}
