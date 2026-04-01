namespace HW2
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is a radius of a circle? ");
            double r = System.Convert.ToDouble(Console.ReadLine());
            double π = Math.PI;
            double l = 2 * π * r;
            double S = π * r * r;
            double V = 4 / 3 * π * r * r * r;
            Console.WriteLine($"Length: {l:F2}.");
            Console.WriteLine($"Area: {S:F2}.");
            Console.WriteLine($"Volume: {V:F2}.");
        }
    }
}