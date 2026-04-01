using HW_04.Helpers;
namespace HW_04
{
    internal class Task09
    {
        public static void Run()
        {
            int number = ProgramHelpers.ReadInt("Enter an integer number:");
            int sumOfDigits = 0;

            if (number == 0)
                sumOfDigits = 0;
            else
            {
                for (int tempNumber = Math.Abs(number); tempNumber > 0; tempNumber /= 10)
                {
                    sumOfDigits += tempNumber % 10;
                }
            }

            Console.WriteLine($"The sum of digits of {number} is: {sumOfDigits}");
        }
    }
}
