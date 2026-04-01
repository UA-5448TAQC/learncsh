using StructDog.Structs;

namespace StructDog;

internal class Program
{

    static void Main(string[] args)
    {
        string name = EnterStringValue("dog name");

        string mark = EnterStringValue("dog mark");

        int age = EnterIntegerValue();

        Dog myDog = new(name, mark, age);

        Console.WriteLine("\nDog information:");
        Console.WriteLine(myDog.ToString());
    }

    private static string EnterStringValue(string text)
    {
        do
        {
            Console.WriteLine($"Enter the {text} :");
            string result = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(result) && !result.Any(char.IsDigit))
            {
                return result;
            }

            Console.WriteLine($"Invalid input. Please enter a valid {text}.");
        }
        while (true);
    }

    private static int EnterIntegerValue()
    {
        do
        {
            Console.WriteLine($"Enter the age :");

            if (Int32.TryParse(Console.ReadLine() ?? string.Empty, out int result) && result > 0)
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }
        while (true);
    }
}

