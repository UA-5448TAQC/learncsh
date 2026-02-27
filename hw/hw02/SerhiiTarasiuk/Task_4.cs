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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Please enter a first integer A:");
            int intA = ReadInt();

            Console.WriteLine("Please enter a second integer B:");
            int intB = ReadInt();

            bool result;

            if (intA < 0 || intB < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = false;
                Console.WriteLine("One of the integers is negative. And Boolean result is {0}", result);
                Console.ForegroundColor = ConsoleColor.Yellow;
               
            }
            else if (intA == 0 && intB == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your integers are ZEROs.");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = false;
                Console.WriteLine("Integer A and Integer B are positive. And Boolean result is {0}", result);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}
