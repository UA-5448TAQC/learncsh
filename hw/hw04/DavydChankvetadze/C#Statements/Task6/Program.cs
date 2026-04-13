namespace Task6;

internal class Program
{
    private static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        var (drink, price) = ReadDrink();

        PrintResult(drink, price);
    }

    private static (string, double) ReadDrink()
    {
        do
        {
            Console.WriteLine("Enter drink name (coffee, tea, juice, water): ");

            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid drink.");
                continue;
            }

            string drink = input.ToLower();
            double? price = GetDrinkPrice(drink);

            if (price != null)
            {
                return (drink, price!.Value);
            }

            Console.WriteLine("Unknown drink. Please try again.");
        }
        while (true);
    }

    private static double? GetDrinkPrice(string drink)
    {
        return drink switch
        {
            "coffee" => 3.50,
            "tea" => 2.50,
            "juice" => 4.00,
            "water" => 1.50,
            _ => null,
        };
    }

    private static void PrintResult(string drink, double price)
    {
        Console.WriteLine("\nDrink: " + drink);
        Console.WriteLine("Price: $" + price);
    }
}
