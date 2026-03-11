namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        int monthNumber;

        while (true)
        {
            Console.Write("Enter a month number (1-12): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out monthNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Month must be between 1 and 12.");
                continue;
            }

            break;
        }

        int days;

        switch (monthNumber)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;

            case 2:
                days = 28;
                break;

            default:
                days = 0;
                break;
        }

        Console.WriteLine($"Number of days: {days}");
    }
}
