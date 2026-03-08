using HW_04;
using HW_04.Helpers;

internal class Program
{
    static void Main(string[] args)
    {
        ProgramHelpers helpers = new ProgramHelpers();

        while (true)
        {
            
            Console.WriteLine("Choose task:");
            Console.WriteLine("1 - Task01: Count 'a' 'o' 'i' 'e' in a string");
            Console.WriteLine("2 - Task02");
            Console.WriteLine("--- or press End to exit ---");

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("\n");
                    Task01.Run();
                    helpers.EndOfTask();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    //Task02.Run();
                    break;

                case ConsoleKey.End:
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unknown task.");
                    Console.ResetColor();

                    Console.WriteLine("Press any key to retry.");
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}