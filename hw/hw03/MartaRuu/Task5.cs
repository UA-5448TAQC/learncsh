using System.Transactions;

namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter day number: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month number: ");
            int month = int.Parse(Console.ReadLine());
            bool correctMonth = month >= 1 && month <= 12;
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool correctDay = correctMonth && day >= 1 && day <= daysInMonth[month - 1];
            Console.WriteLine($"Entered date: {correctDay}");
        }
    }
}
