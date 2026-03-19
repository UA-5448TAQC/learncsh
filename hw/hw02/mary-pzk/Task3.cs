namespace HW2
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three characters, pressing Enter after each one.");
            Console.WriteLine("First: ");
            char firstChar = Console.ReadLine()[0];
            Console.WriteLine("Second: ");
            char secondChar = Console.ReadLine()[0];
            Console.WriteLine("Third: ");
            char thirdChar = Console.ReadLine()[0];
            Console.WriteLine($"You entered {firstChar}, {secondChar}, {thirdChar}.");
        }
    }
}