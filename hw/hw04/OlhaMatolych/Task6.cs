
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please select any of the following drinks: coffee, tea, juice, water");
            string? text = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Input cannot be empty. Please select some drink:");
                text = Console.ReadLine();
            }
            switch (text)
            {
                case "coffee":
                    Console.WriteLine("Drink: Coffee");
                    Console.WriteLine("Price: 80.50");
                    break;
                case "tea":
                    Console.WriteLine("Drink: Tea");
                    Console.WriteLine("Price: 30.50");
                    break;
                case "juice":
                    Console.WriteLine("Drink: Juice");
                    Console.WriteLine("Price: 55.00");
                    break;
                case "water":
                    Console.WriteLine("Drink: Water");
                    Console.WriteLine("Price: 20.50");
                    break;
                default:
                    Console.WriteLine("Unknown drink.");
                    break;
            }
        }
    }
}
