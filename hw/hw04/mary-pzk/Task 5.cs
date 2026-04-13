namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }
        }
    }
}
