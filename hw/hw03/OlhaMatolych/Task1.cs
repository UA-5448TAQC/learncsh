using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;

            Console.WriteLine("Please enter the first float number:");
            while (!float.TryParse(Console.ReadLine(), out num1))

            {
                Console.WriteLine("Invalid input. Enter a valid float number:");
            }

            Console.WriteLine("Please enter the second float number:");
            while (!float.TryParse(Console.ReadLine(), out num2))

            {
                Console.WriteLine("Invalid input. Enter a valid float number:");
            }

            Console.WriteLine("Please enter the third float number:");
            while (!float.TryParse(Console.ReadLine(), out num3))

            {
                Console.WriteLine("Invalid input. Enter a valid float number:");
            }

            bool isNum1InRange = num1 >= -5 && num2 <= 5;
            bool isNum2InRange = num1 >= -5 && num2 <= 5;
            bool isNum3InRange = num1 >= -5 && num2 <= 5;

            bool allInRange = isNum1InRange && isNum2InRange && isNum3InRange;

            Console.WriteLine("All numbers are in range [-5; 5]: " + allInRange);
        }
    }
}
   
