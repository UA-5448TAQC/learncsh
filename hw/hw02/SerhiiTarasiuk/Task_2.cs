namespace ConsoleApp1
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("How are you?");
            string mood = (Console.ReadLine());

            while (mood == string.Empty)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Close Your eyes and take a deep breath.\n" +
                    "Then try to express your feelings. So how are U?");
                mood = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are {0}.", mood);   
        }
    }
}
