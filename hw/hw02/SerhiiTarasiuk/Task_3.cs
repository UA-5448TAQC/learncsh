namespace ConsoleApp1
{
    internal class Task_3
    {
        static void Main(string[] args)
        {
            static char ReadSingleChar()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    
                    if (input.Length == 1)
                    {
                        return input[0];
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO NO NO... Char is one character. Try again");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Please enter a first single char A:");
            char charA = ReadSingleChar();

            Console.WriteLine("Please enter a second single char B:");
            char charB = ReadSingleChar();

            Console.WriteLine("Please enter a third single char C:");
            char charC = ReadSingleChar();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("You entered: A = {0}, B = {1}, C = {2}", charA, charB, charC);

            Console.ResetColor();
        }
    }
}
