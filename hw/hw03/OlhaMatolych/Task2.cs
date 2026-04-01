using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Please enter the first int number:");
            while (!int.TryParse(Console.ReadLine(), out num1))

            {
                Console.WriteLine("Invalid input. Enter a valid int number:");
            }

            Console.WriteLine("Please enter the second int number:");
            while (!int.TryParse(Console.ReadLine(), out num2))

            {
                Console.WriteLine("Invalid input. Enter a valid int number:");
            }

            Console.WriteLine("Please enter the third int number:");
            while (!int.TryParse(Console.ReadLine(), out num3))

            {
                Console.WriteLine("Invalid input. Enter a valid int number:");
            }

            int max = num1;
            if (num2 > max) max = num2;
            if (num3 > max) max = num3;

            int min = num1;
            if (num2 < min) min = num2;
            if (num3 < min) min = num3;

            //bool isNum1InRange = num1 >= -5 && num2 <= 5;
            //bool isNum2InRange = num1 >= -5 && num2 <= 5;
            //bool isNum3InRange = num1 >= -5 && num2 <= 5;

            //bool allInRange = isNum1InRange && isNum2InRange && isNum3InRange;

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }
    }
}
   
