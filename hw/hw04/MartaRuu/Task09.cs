namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 9");
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum of digits = " + sum);
        }
    }
}