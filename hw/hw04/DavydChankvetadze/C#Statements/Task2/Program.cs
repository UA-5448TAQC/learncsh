namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        int monthNumber = EnterMonthNumber();

        int days = GetDaysInMonth(monthNumber);

        Console.WriteLine($"Number of days: {days}");
    }

    private static int EnterMonthNumber()
    {
        do
        {
            Console.WriteLine($"Enter the month number:");

            if (Int32.TryParse(Console.ReadLine() ?? string.Empty, out int monthNumber))
            {
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    return monthNumber;
                }

                Console.WriteLine("Month must be between 1 and 12.");
            }

            Console.WriteLine("Invalid input. Please enter a valid month number.");
        }
        while (true);
    }

    private static int GetDaysInMonth(int monthNumber)
    {
        return monthNumber switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => 28,
            _ => throw new ArgumentOutOfRangeException(nameof(monthNumber), "Month number must be between 1 and 12.")
        };
    }
}
