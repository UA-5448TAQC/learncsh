namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        string str = EnterText();

        Dictionary<char, int> vowelCounts = CalculateLettersInText(str);

        PrintVowelCounts(vowelCounts);
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

    private static Dictionary<char, int> CalculateLettersInText(string str)
    {
        Dictionary<char, int> vowelCounts = new()
        {
            { 'a', 0 },
            { 'o', 0 },
            { 'i', 0 },
            { 'e', 0 }
        };

        str = str.ToLower();

        foreach (char ch in str)
        {
            if (vowelCounts.TryGetValue(ch, out int value))
            {
                vowelCounts[ch] = ++value;
            }
        }

        return vowelCounts;
    }

    private static void PrintVowelCounts(Dictionary<char, int> vowelCounts)
    {
        Console.WriteLine("\nOccurrences:");
        foreach (var kvp in vowelCounts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
