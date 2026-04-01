
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter integer number " + (i + 1) + ":");

                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number:");
                }
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

                Console.WriteLine("Sum of first 5 numbers: " + sum);
            }
            else
            {
                int product = 1;

                for (int i = 5; i < 10; i++)
                {
                    product *= numbers[i];
                }

                Console.WriteLine("Product of last 5 numbers is: " + product);
            }
        }
    }
}
