namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the days in year: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Entered year is a leap year");
            }
            else
            {
                Console.WriteLine("Entered year is not a leap year");
            }

        }
    }
}