namespace Task5
{
    //enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Sutarday, Sunday };
    enum Month { January = 1, February, March, April, May, June, July, August, September, October, November, December };
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            //Console.Write("Enter day of the week (1-7): ");
            //string Days = Console.ReadLine();

            Console.Write("Enter month (1-12): ");
            int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Invalid date.");
                return;
            }

            Month month = (Month)monthNumber;

            int maxDays = 31;

            if (month == Month.February)
                maxDays = 28;
            else if (month == Month.April ||
                     month == Month.June ||
                     month == Month.September ||
                     month == Month.November)
                maxDays = 30;

            bool isValid = day >= 1 && day <= maxDays;

            Console.WriteLine(isValid ? "Valid date." : "Invalid date.");

        }
    }
}
