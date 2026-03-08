namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task5
            Console.WriteLine("Task5");
            Console.WriteLine("Enter side of the square: ");
            int a = int.Parse(Console.ReadLine());
            int perimeter = 4 * a;
            int area = a * a;
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
        }
    }
}
