namespace ConsoleApp1
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            b = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Performing calculations:");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            if (b != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
            }
            else
            {
                Console.Write("{0} / {1} = ", a, b);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("......NO NO NO. \n This is a long story about dividing by zero... I don't have time to explain it.");
            }
        }
    }
}
