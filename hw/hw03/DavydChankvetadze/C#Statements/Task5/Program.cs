namespace Task5;

internal class Program
{
    static void Main(string[] args)
    {
        string text;

        do
        {
            Console.Write("Enter a string: ");
            text = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(text));

        Console.Write("Every second character: ");

        for (int i = 1; i < text.Length; i += 2)
        {
            Console.Write(text[i]);
        }

        Console.WriteLine();
    }
}
