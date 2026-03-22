namespace Task5;

internal class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        string text = ReadNonEmptyString("Enter a string: ");
        PrintEverySecondCharacter(text);
    }

    static string ReadNonEmptyString(string message)
    {
        string input;

        do
        {
            Console.Write(message);
            input = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(input));

        return input;
    }

    static void PrintEverySecondCharacter(string text)
    {
        Console.Write("Every second character: ");

        for (int i = 1; i < text.Length; i += 2)
        {
            Console.Write(text[i]);
        }
    }
}
