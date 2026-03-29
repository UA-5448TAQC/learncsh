namespace Task5;

internal class Program
{
    private static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        string str = EnterText();
        PrintEverySecondCharacter(str);
    }

    private static string EnterText()
    {
        do
        {
            Console.WriteLine($"Enter the text:");

            string str = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            Console.WriteLine("Invalid input. Please enter a valid text.");
        }
        while (true);
    }

    private static void PrintEverySecondCharacter(string str)
    {
        Console.Write("Every second character: ");

        for (int i = 1; i < str.Length; i += 2)
        {
            Console.Write(str[i]);
        }
    }
}
