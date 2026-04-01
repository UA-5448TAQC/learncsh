namespace ValidDateCheck;

internal class Program
{
    static void Main(string[] args)
    {
        int day = EnterIntegerValue("day");
        int month = EnterIntegerValue("month");

        bool isValid = IsValidDate(day, month);

        if (isValid)
        {
            Console.WriteLine("The date is valid.");
        }
        else
        {
            Console.WriteLine("The date is invalid.");
        }
    }

    private static int EnterIntegerValue(string text)
    {
        do
        {
            Console.WriteLine($"Enter the {text}: ");

            if (Int32.TryParse(Console.ReadLine() ?? string.Empty, out int result) && result > 0)
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }
        while (true);
    }

    private static bool IsValidDate(int day, int month)
    {
        if (month < 1 || month > 12)
        {
            return false;
        }
       
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (day < 1 || day > daysInMonth[month - 1])
        {
            return false;
        }

        return true;
    }
}
