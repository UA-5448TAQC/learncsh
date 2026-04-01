namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
                int[] numbers = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter number " + (i + 1) + ": ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                bool allPositive = true;
                for (int i = 0; i < 5; i++)
                {
                    if (numbers[i] <= 0)
                    {
                        allPositive = false;
                        break;
                    }
                }
                if (allPositive)
                {
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine("Sum = " + sum);
                }
                else
                {
                    int product = 1;
                    for (int i = 5; i < 10; i++)
                    {
                        product *= numbers[i];
                    }
                    Console.WriteLine("Product = " + product);
                }
        }
    }
}