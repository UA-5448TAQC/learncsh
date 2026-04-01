namespace HW_3
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            int a, b, c, max, min;

            Console.WriteLine("Enter the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            c = int.Parse(Console.ReadLine());

            max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine($"Max: {max}");

            min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            Console.WriteLine($"Min: {min}");
        }
    }
}