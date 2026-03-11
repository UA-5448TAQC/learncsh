namespace Task6;

internal class Program
{
    static void Main(string[] args)
    {
        string drink;

        while (true)
        {
            Console.Write("Enter drink name (coffee, tea, juice, water): ");
            drink = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(drink))
            {
                Console.WriteLine("Input cannot be empty.");
                continue;
            }

            bool containsDigits = false;

            foreach (char ch in drink)
            {
                if (char.IsDigit(ch))
                {
                    containsDigits = true;
                    break;
                }
            }

            if (containsDigits)
            {
                Console.WriteLine("Drink name cannot contain digits.");
                continue;
            }

            break;
        }

        drink = drink.ToLower();

        double price;

        switch (drink)
        {
            case "coffee":
                price = 3.50;
                break;

            case "tea":
                price = 2.50;
                break;

            case "juice":
                price = 4.00;
                break;

            case "water":
                price = 1.50;
                break;

            default:
                Console.WriteLine("Unknown drink.");
                return;
        }

        Console.WriteLine("\nDrink: " + drink);
        Console.WriteLine("Price: $" + price);
    }
}
