namespace ConsoleApp1
{
    internal class Task_1
    {
        static void Main(string[] args)
        {

            static int ReadInt()
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("Invalid input. Please enter a valid integer:");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter a = ");
            int a = ReadInt();
            Console.Write("Enter b = ");
            int b = ReadInt();

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
                Console.WriteLine("This is a long story about dividing by zero...");
            }

            Console.ResetColor();
        }
    }
}
