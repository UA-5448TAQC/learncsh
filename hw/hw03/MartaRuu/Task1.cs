namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Enter first number: ");
            float f1 = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float f2 = float.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            float f3 = float.Parse(Console.ReadLine());
            bool all = (f1 >= -5 && f1 <= 5) &&
                        (f2 >= -5 && f2 <= 5) &&
                        (f3 >= -5 && f3 <= 5);
            Console.WriteLine($"All numbers are in [-5; 5] range: {all}");
        }
    }
}
