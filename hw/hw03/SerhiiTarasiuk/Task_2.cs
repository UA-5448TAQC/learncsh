namespace ConsoleApp1
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            int num1 = ReadInt("Enter the first number: ");
            int num2 = ReadInt("Enter the second number: ");
            int num3 = ReadInt("Enter the third number: ");

            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");

            static int ReadInt(string message)
            {
                while (true)
                {
                    Console.WriteLine(message);
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Only integer numbers are allowed.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
