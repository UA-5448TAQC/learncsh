using HW_04;
using HW_04.Helpers;

internal class Program
{
    static void Main(string[] args)
    {
        ProgramHelpers helpers = new ProgramHelpers();

        while (true)
        {

            Console.WriteLine("Choose task by pressing button");

            ProgramHelpers.PrintTask(1, "Read a string str.\nCalculate number of characters: 'a' 'o' 'i' 'e' (uppercase too).");

            ProgramHelpers.PrintTask(2, "Enter month number (1–12).\nOutput number of days in this month.");

            ProgramHelpers.PrintTask(3, "Enter 10 integers.\nIf first 5 are positive → sum.\nElse → product of last 5.");

            ProgramHelpers.PrintTask(4, "Enter integers a and b.\nCount numbers in [a..b] divisible by 3.\nExample: 1..10 → 3 (3,6,9)");

            ProgramHelpers.PrintTask(5, "Enter text.\nPrint every second character.\nExample: Hello → el");

            ProgramHelpers.PrintTask(6, "Enter drink: coffee, tea, juice, water.\nPrint drink name and price (switch).");

            ProgramHelpers.PrintTask(7, "Enter positive integers (stop on negative).\nFind average.\nExample: 1,6,3,9,-8 → (1+6+3+9)/4");

            ProgramHelpers.PrintTask(8, "Check if year is leap.\n(divisible by 4, not by 100, except 400)");

            ProgramHelpers.PrintTask(9, "Find sum of digits.\nExample: 365 → 3+6+5=14");

            ProgramHelpers.PrintTask(0, "Check if number has only odd digits.\nExample: 1357 → true, 246 → false");

            Console.WriteLine("END - to exit ");

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
                    Console.WriteLine("\n");
                    Task02.Run();
                    helpers.EndOfTask();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("\n");
                    Task03.Run();
                    helpers.EndOfTask();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("\n");
                    Task04.Run();
                    helpers.EndOfTask();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.WriteLine("\n");
                    Task05.Run();
                    helpers.EndOfTask();
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Console.WriteLine("\n");
                    Task06.Run();
                    helpers.EndOfTask();
                    break;


                case ConsoleKey.End:
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unknown task.");
                    Console.ResetColor();

                    Console.WriteLine("Press appropriate key to retry.");
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}