namespace SumOfFirstTwoDigitsAfterDecimalPoint;

internal class Program
{
    static void Main(string[] args)
    {
        double number = EnterDoubleValue();

        number = Math.Abs(number);

        int twoDigits = (int)Math.Round((number - Math.Floor(number)) * 100, 2);

        int firstDigit = twoDigits / 10;
        int secondDigit = twoDigits % 10;
        int sum = firstDigit + secondDigit;

        Console.WriteLine($"The sum of the first two digits after the decimal point is: " + sum);
    }

    private static double EnterDoubleValue()
    {
        do
        {
            Console.WriteLine($"Enter a double number: ");

            if (Double.TryParse(Console.ReadLine() ?? string.Empty, out double result) && result > 0)
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }
        while (true);
    }
}
