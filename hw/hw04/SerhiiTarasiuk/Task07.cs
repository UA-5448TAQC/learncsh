using HW_04.Helpers;

namespace HW_04
{
    internal class Task07
    {
        public static void Run()
        {
            {
                int sum = 0;
                int count = 0;

                Console.WriteLine("Enter positive numbers (negative number to stop):");

                while (true)
                {
                    int number = ProgramHelpers.ReadInt("Enter a positive number (negative to stop):");

                    if (number < 0)
                        break;

                    sum += number;
                    count++;
                }

                if (count > 0)
                {
                    double average = (double)sum / count;
                    Console.WriteLine($"Average = {average}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No positive numbers were entered.");
                    Console.ResetColor();
                }
            }
        }
    }
}
