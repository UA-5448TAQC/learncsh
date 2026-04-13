namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the drink (coffee/tea/juice/water)");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "coffee":
                    Console.WriteLine("The price of coffe - 45.00");
                    break;
                case "tea":
                    Console.WriteLine("The price of tea - 40.00");
                    break;
                case "juice":
                    Console.WriteLine("The price of juice - 30.00");
                    break;
                case "water":
                    Console.WriteLine("The price of water - 25.00");
                    break;
                default:
                    Console.WriteLine("No such drinks");
                    break;
            }

        }
    }
}
