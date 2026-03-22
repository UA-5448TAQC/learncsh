namespace Task8;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        int year = ReadYear();
        bool isLeapYear = IsLeapYear(year);

        PrintResult(year, isLeapYear);
    }

    static int ReadYear()
    {
        int year;

        while (true)
        {
            Console.Write("Enter a year: ");

            if (int.TryParse(Console.ReadLine(), out year))
            {
                if (year > 0)
                    return year;
                else
                    Console.WriteLine("Year must be positive.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) ||
               (year % 400 == 0);
    }

    static void PrintResult(int year, bool isLeapYear)
    {
        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
