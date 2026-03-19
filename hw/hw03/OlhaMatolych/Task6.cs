
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double number;

            Console.WriteLine("Enter a decimal number:");

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number:");
            }

            if (number < 0)
            {
                number = -number;
            }

            int twoDigits = (int)(number * 100) % 100;

            int firstDigit = twoDigits / 10;
            int secondDigit = twoDigits % 10;

            int sum = firstDigit + secondDigit;

            Console.WriteLine(firstDigit + " + " + secondDigit + " = " + sum);
        }
    }
}