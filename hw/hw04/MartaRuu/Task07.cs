namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7");
            int sum = 0;
            int count = 0;
            int number;
            do
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if (number >= 0)
                {
                    sum += number;
                    count++;
                }
            } while (number >= 0);
            if (count > 0)
                Console.WriteLine("Average = " + (double)sum / count);
            else
                Console.WriteLine("No positive numbers");
        }
    }
}