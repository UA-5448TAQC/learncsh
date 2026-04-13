namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a month number:");
            int month;
            if (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month has 31 days.");
                    break;
                case 2:
                    Console.WriteLine("This month has 28 days, or 29 in a leap year.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month has 30 days.");
                    break;
                default:
                    Console.WriteLine("The number should be between 1 and 12.");
                    break;
            }
        }
    }
}
