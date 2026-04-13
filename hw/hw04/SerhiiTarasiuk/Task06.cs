using HW_04.Helpers;

namespace HW_04
{
    internal class Task06
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("We have the following drinks available: Coffee, Tea, Juice, Water");
            Console.WriteLine("Enter the name of the drink:");

            string drink = ProgramHelpers.ReadNonEmptyString("Enter the name of the drink:").ToLower();
            Console.ResetColor();

            switch (drink)
            {
                case "coffee":
                    Console.WriteLine("Drink name: Coffee\nPrice: UAH 50");
                    break;
                case "tea":
                    Console.WriteLine("Drink name: Tea\nPrice: UAH 40");
                    break;
                case "juice":
                    Console.WriteLine("Drink name: Juice\nPrice: UAH 60");
                    break;
                case "water":
                    Console.WriteLine("Drink name: Water\nPrice: UAH 20");
                    break;
                default:
                    Console.WriteLine("Unknown drink. Please enter one of the following: coffee, tea, juice, water.");
                    break;
            }
        }
    }
}
