namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Task1");
            int a;
            int b;
            Console.WriteLine("Enter value a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int diff = a - b;
            int mult = a * b;
            int div = a / b;
            Console.WriteLine("Results: ");
            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b = {diff}");
            Console.WriteLine($"a * b = {mult}");
            Console.WriteLine($"a / b = {div}");
        }
    }
}
