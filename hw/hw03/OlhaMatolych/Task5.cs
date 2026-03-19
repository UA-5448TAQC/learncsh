
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int month;
            int day;

            Console.WriteLine("Enter month (1-12):");
            while (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.WriteLine("Invalid input. Please enter a whole number:");
            }

            Console.WriteLine("Enter day:");
            while (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("Invalid input. Please enter a whole number:");
            }

            bool isValid = false;

            if (month >= 1 && month <= 12)
            {
                int daysInMonth = 0;

                if (month == 1 || month == 3 || month == 5 || month == 7 ||
                    month == 8 || month == 10 || month == 12)
                {
                    daysInMonth = 31;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    daysInMonth = 30;
                }
                else if (month == 2)
                {
                    daysInMonth = 28;
                }

                if (day >= 1 && day <= daysInMonth)
                {
                    isValid = true;
                }
            }

            Console.WriteLine("Valid date: " + isValid);
        }
    }
}