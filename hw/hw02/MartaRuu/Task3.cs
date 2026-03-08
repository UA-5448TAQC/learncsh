namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task3
            Console.WriteLine("Task3");
            Console.WriteLine("Enter first character: ");
            char one = Console.ReadLine()[0];
            Console.WriteLine("Enter second character: ");
            char two = Console.ReadLine()[0];
            Console.WriteLine("Enter third character: ");
            char three = Console.ReadLine()[0];
            Console.WriteLine($"You entered {one}, {two}, {three}.");
        }
    }
}
