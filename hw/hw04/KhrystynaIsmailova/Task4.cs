namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 'a' value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 'b' value: ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count} integers are divisible by 3", count);

        }
    }
}