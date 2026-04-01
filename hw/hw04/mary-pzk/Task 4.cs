namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} numbers divisible by 3 in the range [{a}..{b}].");
        }
    }
}
