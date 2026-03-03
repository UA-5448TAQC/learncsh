namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task4
            Console.WriteLine("Task4");
            Console.WriteLine("Enter first integer: ");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int two = int.Parse(Console.ReadLine());
            bool bothPositive = (one > 0) && (two > 0);
            Console.WriteLine($"Both numbers are positive: {bothPositive}");
        }
    }
}
