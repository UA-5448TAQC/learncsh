namespace SimpleQuestion;

internal class Program
{
    static void Main(string[] args)
    {
        string answer = string.Empty;

        while (answer == string.Empty)
        {
            Console.WriteLine("How are you?");
            answer = Console.ReadLine() ?? string.Empty;
        }

        Console.WriteLine($"You are {answer}");
    }
}
