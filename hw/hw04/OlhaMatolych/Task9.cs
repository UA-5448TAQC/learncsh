
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

            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine($"The sum of the digits is {sum}");
        }
    }
}