namespace ConsoleApp1
{
    internal class Task_5
    {
        enum DaysInMonth
        {
            January = 31,
            February = 28,
            March = 31,
            April = 30,
            May = 31,
            June = 30,
            July = 31,
            August = 31,
            September = 30,
            October = 31,
            November = 30,
            December = 31
        }

        static void Main(string[] args)
        {
            int month = ReadInt("Enter the month from 1 to 12: ");

            while (!(month > 0 && month < 13))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a value between 1 and 12.");
                Console.ResetColor();
                month = ReadInt("Enter the month from 1 to 12: ");
            }

            string monthName = Enum.GetNames(typeof(DaysInMonth))[month - 1];
            int maxDays = (int)Enum.Parse(typeof(DaysInMonth), monthName);

            int day = ReadInt("Enter the day: ");

            if (day >= 1 && day <= maxDays)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You entered {day} of {monthName}.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"In {monthName} there are only {maxDays} days.");
                Console.ResetColor();
            }
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                    return result;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Only integer numbers are allowed.");
                Console.ResetColor();
            }
        }
    }
}