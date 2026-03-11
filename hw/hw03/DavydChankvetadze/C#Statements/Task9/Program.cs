namespace Task9;

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

        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;  
            number /= 10;        
        }

        Console.WriteLine($"Sum of digits: {sum}");
    }
}
