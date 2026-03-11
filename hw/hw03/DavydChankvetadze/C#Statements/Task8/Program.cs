namespace Task8;

internal class Program
{
    static void Main(string[] args)
    {
        int year;

        while (true)
        {
            Console.Write("Enter a year: ");

            if (int.TryParse(Console.ReadLine(), out year))
            {
                if (year > 0)
                    break;
                else
                    Console.WriteLine("Year must be positive.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }

        bool isLeapYear =
            (year % 4 == 0 && year % 100 != 0) ||
            (year % 400 == 0);

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
