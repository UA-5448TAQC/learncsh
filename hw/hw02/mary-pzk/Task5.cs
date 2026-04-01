namespace HW2
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Side length (cm):");
            int a = System.Convert.ToInt32(Console.ReadLine());
            int area = a * a;
            int perimeter = 4 * a;
            Console.WriteLine($"The area of the square is {area} cm².");
            Console.WriteLine($"The perimeter of the square is {perimeter} cm.");

        }
    }
}