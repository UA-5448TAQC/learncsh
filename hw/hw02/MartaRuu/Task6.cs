namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task6
            Console.WriteLine("Task6");
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name} ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is {name}, your age is {age}");
        }
    }
}
