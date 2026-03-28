namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a double number: ");
            double number = double.Parse(Console.ReadLine()!);

            double fractional = number % 1;
            int twoDigits = (int)(fractional * 100);

            Console.WriteLine($"First two numbers after the dot: {twoDigits}");

            int firstDigit = twoDigits / 10;
            int secondDigit = twoDigits % 10;

            int sum = firstDigit + secondDigit;

            Console.WriteLine($"{firstDigit} + {secondDigit} = {sum}");

        }
    }
}
