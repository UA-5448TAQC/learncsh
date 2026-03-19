namespace ConsoleApp1
{
    internal class Task_7
    {
        static void Main(string[] args)
        {

            int hour = ReadInt("Enter the hour of the day (0-23): ");

            switch (hour)
            {
                case int h when (h >= 6 && h <= 11):
                    Console.WriteLine("Good morning!");
                    break;
                case int h when (h >= 12 && h <= 17):
                    Console.WriteLine("Good afternoon!");
                    break;
                case int h when (h >= 18 && h <= 22):
                    Console.WriteLine("Good evening!");
                    break;
                default:
                    Console.WriteLine("Good night!");
                    break;
            }

                static int ReadInt(string message)
                {
                while (true)
                {
                    Console.WriteLine(message);
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int result) && result >= 0 && result <= 23)
                        return result;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Only integer numbers from 0 to 23 are allowed.");
                    Console.ResetColor();
                }
            }
        }
    }
}
