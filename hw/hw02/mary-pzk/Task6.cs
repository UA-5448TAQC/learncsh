namespace HW2
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine()!;
            Console.Write($"How old are you, {name}? ");
            int age = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you are {age} years old.");
        }
    }
}