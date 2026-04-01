using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Task6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter your name.");
                name = Console.ReadLine();
            }

            Console.WriteLine($"How old are you, {name} ?");
            
            int age;

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please enter your age as a whole number.");
            }

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}