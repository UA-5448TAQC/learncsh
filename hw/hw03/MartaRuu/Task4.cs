using System.Transactions;

namespace ConsoleApp3;
struct Dog
{
    public string Name;
    public string Mark; 
    public int Age;

    public override string ToString()
    {
        return $"Dog: Name = {Name}, Mark = {Mark}, Age = {Age}";
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4");
        Dog myDog;
            Console.WriteLine("Enter dog name: ");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Enter dog mark: ");
            myDog.Mark = Console.ReadLine();
            Console.WriteLine("Enter dog age: ");
            myDog.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(myDog.ToString());

        }
    }
