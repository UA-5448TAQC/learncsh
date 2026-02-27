namespace ConsoleApp1
{
    internal class Task_5
    {
        static void Main(string[] args)
        {
            static int ReadInt()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    
                    if (int.TryParse(input, out int result) && result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO NO NO... Only positive digits. Try again");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Please enter a side of the square A:");
            int sideA = ReadInt();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Performing calculations.... \n" +
                "Your square's area is: " + (sideA * sideA) + "\n" +
                "Your square's perimeter is: " + (4 * sideA));

            Console.ResetColor();
        }
    }
}
