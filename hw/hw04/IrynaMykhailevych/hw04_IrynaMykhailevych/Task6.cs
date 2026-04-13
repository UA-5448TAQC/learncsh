using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task6
    {
        public static void Run() 
        {
            Console.WriteLine("Enter a drink: ");
            string drink = Console.ReadLine();

            drink = drink.ToLower();

            switch (drink)
            {
                case "coffee":
                    Console.WriteLine("Drink: coffee, Price: 3$");
                    break;
                case "tea":
                    Console.WriteLine("Drink: tea, Price: 2$");
                    break;
                case "juice":
                    Console.WriteLine("Drink: juice, Price: 4$");
                    break;
                case "water":
                    Console.WriteLine("Drink: water, Price: 1$");
                    break;
                default:
                    Console.WriteLine("Unknown drink.");
                    break;
            }
        }
    }
} 
