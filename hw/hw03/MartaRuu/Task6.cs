using System.Transactions;

namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter a double number: ");
            double a = double.Parse(Console.ReadLine());
            double da = Math.Abs(a);
            int d1 = (int)(da * 10) % 10;
            int d2 = (int)(da * 100) % 10;
            int sum = d1 + d2;
            Console.WriteLine($"First two digits: {d1} and {d2}. Sum = {sum}");
        }
    }
}
