namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6");
            Console.Write("Enter drink name: ");
            string drink = Console.ReadLine().ToLower();
            switch (drink)
            {
                case "coffee":
                    Console.WriteLine("Drink: coffee");
                    Console.WriteLine("Price: 50");
                    break;

                case "tea":
                    Console.WriteLine("Drink: tea");
                    Console.WriteLine("Price: 40");
                    break;

                case "juice":
                    Console.WriteLine("Drink: juice");
                    Console.WriteLine("Price: 30");
                    break;

                case "water":
                    Console.WriteLine("Drink: water");
                    Console.WriteLine("Price: 20");
                    break;

                default:
                    Console.WriteLine("Unknown drink");
                    break;
            }
        }
    }
}