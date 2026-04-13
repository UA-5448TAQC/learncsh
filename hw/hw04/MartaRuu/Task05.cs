namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }
    }
}