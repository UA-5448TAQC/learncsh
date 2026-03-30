
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;

            Console.WriteLine("Enter first integer:");

            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Please enter a whole number:");
            }

            Console.WriteLine("Enter second integer:");

            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a whole number:");
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine($"Numbers divisible by 3 in range [{a}..{b}]:");

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
