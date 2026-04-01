namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            float c = float.Parse(Console.ReadLine());

            bool inRange =
                a >= -5 && a <= 5 &&
                b >= -5 && b <= 5 &&
                c >= -5 && c <= 5;

            Console.WriteLine("All numbers in range [-5;5]: " + inRange);
        }
    }
}