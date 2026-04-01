
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the year:");
            int year = ReadInt();

            bool isLeapYear =
                (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            Console.WriteLine(isLeapYear
                ? $"{year} is a leap year."
                : $"{year} is not a leap year.");
        }

        static int ReadInt()
        {
            int year;

            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid input. Please enter a year:");
            }

            return year;
        }
    }
}