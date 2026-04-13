
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter some text:");
            string? text = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Input cannot be empty. Please enter some text.");
                text = Console.ReadLine();
            }

            Console.WriteLine("Every second character: ");

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }
    }
}
