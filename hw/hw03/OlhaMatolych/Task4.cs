
namespace ConsoleApp1
{
    internal class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return "Dog Name: " + name + ", Mark: " + mark + ", Age: " + age;
            }
        }
        static void Main()
        {
            Dog myDog;

            Console.WriteLine("Enter dog's name:");
            myDog.name = Console.ReadLine();

            while (myDog.name == "")
            {
                Console.WriteLine("Name cannot be empty. Enter dog's name:");
                myDog.name = Console.ReadLine();
            }

            Console.WriteLine("Enter dog's mark (breed):");
            myDog.mark = Console.ReadLine();

            while (myDog.mark == "")
            {
                Console.WriteLine("Mark cannot be empty. Enter dog's mark:");
                myDog.mark = Console.ReadLine();
            }

            Console.WriteLine("Enter dog's age:");
            while (!int.TryParse(Console.ReadLine(), out myDog.age) || myDog.age < 0)
            {
                Console.WriteLine("Invalid input. Enter a non-negative whole number:");
            }

            Console.WriteLine("\nDog information:");
            Console.WriteLine(myDog.ToString());
        }
    }
}