
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            while (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Please enter some text.");
                text = Console.ReadLine();
            }
            int count = 0;

            foreach (char c in text)
            {
                if (c == 'a' || c == 'o' || c == 'i' || c == 'e' || c == 'A' || c == 'O' || c == 'I' || c == 'E')
                    count++;
            }

            Console.WriteLine("Count: " + count);
        }
    }
}