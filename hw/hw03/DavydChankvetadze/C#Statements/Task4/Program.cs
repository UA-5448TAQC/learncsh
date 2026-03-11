namespace Task4;

internal class Program
{
    static void Main(string[] args)
    {
        int a, b;

        while (true)
        {
            Console.Write("Enter integer a: ");
            if (int.TryParse(Console.ReadLine(), out a))
                break;

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        while (true)
        {
            Console.Write("Enter integer b: ");
            if (int.TryParse(Console.ReadLine(), out b))
                break;

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Count of numbers divisible by 3: {count}");
    }
}
