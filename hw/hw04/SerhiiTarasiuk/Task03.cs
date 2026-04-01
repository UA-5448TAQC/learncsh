using HW_04.Helpers;
namespace HW_04
{
    internal class Task03
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ProgramHelpers.ReadInt($"Number {i + 1}:");
            }
            bool firstFivePositive = true;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    firstFivePositive = false;
                    break;
                }
            }
            if (firstFivePositive)
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"Sum of the first 5 positive integers: {sum}");
            }
            else
            {
                int product = 1;
                for (int i = 5; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }
                Console.WriteLine($"Product of the last 5 integers: {product}");
            }
        }
    }
}
