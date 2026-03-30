using System;

namespace ConsoleApp1
{
    internal static class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Task 6 — Drink menu");

            string drink = InputHelper.ReadNonEmptyString("Enter drink name (coffee, tea, juice, water):").ToLower();

            switch (drink)
            {
                case "coffee":
                    PrintDrink("Coffee", 3.50m);
                    break;

                case "tea":
                    PrintDrink("Tea", 2.00m);
                    break;

                case "juice":
                    PrintDrink("Juice", 4.00m);
                    break;

                case "water":
                    PrintDrink("Water", 1.00m);
                    break;

                default:
                    ConsoleHelper.WriteError("Dunno abt that...");
                    break;
            }

            InputHelper.PrintSeparator();
        }

        private static void PrintDrink(string name, decimal price)
        {
            ConsoleHelper.WriteSuccess($"Drink: {name}");
            ConsoleHelper.WriteSuccess($"Price: {price:F2}");
            InputHelper.completedTasks++;
        }
    }
}