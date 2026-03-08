using System.Transactions;

namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7");
            Console.Write("Enter hour (0-23): ");
            int h = int.Parse(Console.ReadLine());
            if (h < 0 || h > 23)
            {
                Console.WriteLine("Invalid hour.");
            }
            else if (h >= 6 && h <= 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (h >= 12 && h <= 17)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (h >= 18 && h <= 21)
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
