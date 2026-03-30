
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Enter the number:");

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number:");
            }

            num = Math.Abs(num);

            bool onlyOddDigits = true;

            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    onlyOddDigits = false;
                    break;
                }

                num /= 10;
            }

            Console.WriteLine($"Contains only odd digits: {onlyOddDigits}");
        }
    }
}