
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a month number (1–12):");
            int month;

            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Please enter a month number (1–12):");
            }

                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine("30 days");
                }
                else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.WriteLine("31 days");
                }
                else if (month == 2) 
                {
                    Console.WriteLine("28 days");
                }
            }
        }
    }