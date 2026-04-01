namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a drink name: ");
            string drink = Console.ReadLine()!;
            int price = 0;

            switch (drink)
            {
                case "coffee":
                    price = 80;
                    break;

                case "tea":
                    price = 50;
                    break;

                case "juice":
                    price = 95;
                    break;

                case "water":
                    price = 15;
                    break;

                default:
                    Console.WriteLine("This drink is not availabe.");
                    return;
            }
            Console.WriteLine($"Drink: {drink}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
