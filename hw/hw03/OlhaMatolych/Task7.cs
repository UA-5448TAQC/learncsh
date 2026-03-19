
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int h;

            Console.WriteLine("Enter hour (0-23):");

            while (!int.TryParse(Console.ReadLine(), out h) || h < 0 || h > 23)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 23:");
            }

            if (h >= 6 && h <= 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (h >= 12 && h <= 17)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (h >= 18 && h <= 22)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }
        }
    }
}