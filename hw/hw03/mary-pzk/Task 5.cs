namespace HW_3
{
    internal class Task_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month:");
            int month;
            if (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Month is invalid. Month must be between 1 and 12.");
                return;
            }

            int maxDay = 31;
            if (month == 2)
            {
                maxDay = 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                maxDay = 30;
            }

            Console.WriteLine("Enter day:");

            if (int.TryParse(Console.ReadLine(), out int day))
            {
                if (day >= 1 && day <= maxDay)
                {
                    Console.WriteLine("Day is valid.");
                }
                else
                {
                    Console.WriteLine($"Day is invalid. Day must be between 1 and {maxDay}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}