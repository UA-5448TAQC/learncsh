using HW_04.Helpers;

namespace HW_04
{
    internal class Task10
    {
        public static void Run()
        {
            int number = ProgramHelpers.ReadInt("Enter an integer number:");
            bool allDigitsOdd = true;
            if (number == 0)
                allDigitsOdd = false;
            else
            {
                for (int tempNumber = Math.Abs(number); tempNumber > 0; tempNumber /= 10)
                {
                    int digit = tempNumber % 10;
                    if (digit % 2 == 0)
                    {
                        allDigitsOdd = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"Yo! Your number {number} contain only odd digits? {allDigitsOdd}");
        }
    }
}