namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check whether it is a leap year");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("This year is a leap year.");
            }
            else
            {
                Console.WriteLine("This year is not a leap year.");
            }
        }
    }
}
