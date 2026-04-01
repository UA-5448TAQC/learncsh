namespace HW2
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = System.Convert.ToInt32(Console.ReadLine());
            bool arePositive = a > 0 && b > 0;
            Console.WriteLine($"Are your numbers positive? - {arePositive}.");
        }
    }
}