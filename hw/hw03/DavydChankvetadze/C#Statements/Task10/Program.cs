namespace Task10;

internal class Program
{
    static void Main(string[] args)
    {
        int number;

        while (true)
        {
            Console.Write("Enter an integer number: ");

            if (int.TryParse(Console.ReadLine(), out number))
                break;

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        number = Math.Abs(number);

        bool onlyOddDigits = true;

        if (number == 0)
        {
            onlyOddDigits = false;
        }

        while (number > 0)
        {
            int digit = number % 10;

            if (digit % 2 == 0)
            {
                onlyOddDigits = false;
                break;
            }

            number /= 10;
        }

        Console.WriteLine(onlyOddDigits);
    }
}