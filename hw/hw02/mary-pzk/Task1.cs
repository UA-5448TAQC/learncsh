namespace HW2
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first value is: ");
            int a = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second value is: ");
            int b = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
            Console.WriteLine($"The difference between {a} and {b} is: {a - b}");
            Console.WriteLine($"The product of {a} and {b} is: {a * b}");
            if (b == 0)
            {
                Console.WriteLine("Division by zero is forbidden");
            }
            else
            {
                Console.WriteLine($"The division of {a} by {b} is: {a / b}");
            }
        }
    }
}
