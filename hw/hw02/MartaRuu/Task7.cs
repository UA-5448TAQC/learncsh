namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task7
            Console.WriteLine("Task7");
            Console.WriteLine("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            double length = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * r * r * r;
            Console.WriteLine($"Length of the circle: {length:F1}");
            Console.WriteLine($"Area of the circle: {area:F1}");
            Console.WriteLine($"Volume of the circle: {volume:F1}");
        }
    }
}
