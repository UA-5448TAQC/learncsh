namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter some value: ");
            string text = Console.ReadLine();


            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }

        }
    }
}
