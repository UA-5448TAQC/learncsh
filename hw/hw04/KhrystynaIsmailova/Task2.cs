
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the month number (1-12): ");

            int month = int.Parse(Console.ReadLine());
            int days = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;

                case 2:
                    days = 28;
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    return;
            }


            Console.WriteLine($"This month has {days} days");

        }
    }
}
