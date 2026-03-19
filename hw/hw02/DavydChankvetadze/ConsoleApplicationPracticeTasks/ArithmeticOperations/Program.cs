namespace ArithmeticOperations;

internal class Program
{
    static void Main(string[] args)
    {
        int a = EnterIntValue("first");
        int b = EnterIntValue("second");

        Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        Console.WriteLine($"The difference of {a} and {b} is: {a - b}");
        Console.WriteLine($"The product of {a} and {b} is: {a * b}");
        Console.WriteLine($"The quotient of {a} and {b} is: {(b != 0 ? ((double)a / b).ToString() : "undefined (division by zero)")}");
    }

    private static int EnterIntValue(string position)
    {
        do 
        {
            Console.WriteLine($"Enter the {position} number:");

            string input = Console.ReadLine() ?? string.Empty;
            bool result = Int32.TryParse(input, out int c);

            if (result) 
            {
                return c;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        while (true);
    }
}
