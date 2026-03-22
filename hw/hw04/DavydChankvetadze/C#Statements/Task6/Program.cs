namespace Task6;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        string drink = ReadDrink();
        double? price = GetDrinkPrice(drink);

        if (price == null)
        {
            Console.WriteLine("Unknown drink.");
            return;
        }

        PrintResult(drink, price.Value);
    }

    static string ReadDrink()
    {
        string input;

        while (true)
        {
            Console.Write("Enter drink name (coffee, tea, juice, water): ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty.");
                continue;
            }

            return input.ToLower();
        }
    }

    static double? GetDrinkPrice(string drink)
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

    static void PrintResult(string drink, double price)
    {
        Console.WriteLine("\nDrink: " + drink);
        Console.WriteLine("Price: $" + price);
    }
}
