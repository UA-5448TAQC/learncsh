using HW_04.Helpers;

namespace HW_04
{
    internal class Task02
    {
        public static void Run()
            {

            while (true)
            {
                int monthNumber = ProgramHelpers.ReadInt("Enter month number (1–12):");

                int days;

                switch (monthNumber)
                {
                    case 1:
                        days = 31;
                        break;
                    case 2:
                        days = 28;
                        break;
                    case 3:
                        days = 31;
                        break;
                    case 4:
                        days = 30;
                        break;
                    case 5:
                        days = 31;
                        break;
                    case 6:
                        days = 30;
                        break;
                    case 7:
                        days = 31;
                        break;
                    case 8:
                        days = 31;
                        break;
                    case 9:
                        days = 30;
                        break;
                    case 10:
                        days = 31;
                        break;
                    case 11:
                        days = 30;
                        break;
                    case 12:
                        days = 31;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid month number. Please enter 1–12.");
                        Console.ResetColor();
                        continue;
                }

                Console.WriteLine($"Month {monthNumber} has {days} days.");
                break;
            }
            
         }
    }
}

