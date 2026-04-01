using System.Transactions;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer: ");
            int c = int.Parse(Console.ReadLine());
            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"Min = {min}, Max = {max}");
        }
    }
}
