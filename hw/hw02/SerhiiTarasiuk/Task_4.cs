namespace ConsoleApp1
{
    internal class Task_4
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
                        Console.WriteLine("NO NO NO... Only digits. Try again");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            Console.WriteLine("Please enter first integer A:");
            int intA = ReadInt();

            Console.WriteLine("Please enter second integer B:");
            int intB = ReadInt();

            bool isPositive = intA > 0 && intB > 0;


            Console.Write($"Both numbers are positive: ");

            if (isPositive) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(isPositive);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(isPositive);
            }

            Console.ResetColor();
        }
    }
}