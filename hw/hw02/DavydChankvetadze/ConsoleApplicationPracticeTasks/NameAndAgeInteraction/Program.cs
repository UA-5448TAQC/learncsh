namespace NameAndAgeInteraction;

internal class Program
{
    static void Main(string[] args)
    {
        string name = EnterNameValue();
        int age = EnterAgeValue(name);
        
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }

    private static string EnterNameValue()
    {
        do
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(name) && !name.All(char.IsDigit))
            {
                return name;
            }

            Console.WriteLine("Invalid input. Please enter a valid name.");
        }
        while (true);
    }

    private static int EnterAgeValue(string name)
    {
        do
        {
            Console.WriteLine($"How old are you, {name}?");

            string input = Console.ReadLine() ?? string.Empty;
            bool result = Int32.TryParse(input, out int c);

            if (result && c > 0)
            {
                return c;
            }

            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
        while (true);
    }
}

