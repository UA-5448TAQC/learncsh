using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine(); // порожній рядок між завданнями
            Task2();
            Console.WriteLine(); // порожній рядок між завданнями
            Task3();
            Console.WriteLine(); // порожній рядок між завданнями
            Task4();
            Console.WriteLine(); // порожній рядок між завданнями
            Task5();
            Console.WriteLine(); // порожній рядок між завданнями
            Task6();
            Console.WriteLine(); // порожній рядок між завданнями
            Task7();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Arithmetic Operations
        static void Task1()
        {
            Console.WriteLine("=== Task 1: Arithmetic Operations ===");

            int a;
            int b;
            Console.WriteLine("Enter value for a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int division = a / b;
            Console.WriteLine("\nResults:");
            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b = {difference}");
            Console.WriteLine($"a * b = {product}");
            Console.WriteLine($"a / b = {division}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        // Simple Question
        static void Task2()
        {
            Console.WriteLine("=== Task 2: Simple Question ===");

            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
        }
        // Working with char
        static void Task3()
        {
            Console.WriteLine("=== Task 3: Working with char ===");

            Console.WriteLine("Enter first character: ");
            char first = Console.ReadLine()[0];

            Console.WriteLine("Enter second character: ");
            char second = Console.ReadLine()[0];

            Console.WriteLine("Enter third character: ");
            char third = Console.ReadLine()[0];

            Console.WriteLine($"You entered {first}, {second}, {third}");
        }
        // Boolean Expression
        static void Task4()
        {
            Console.WriteLine("=== Task 4: Boolean Expression ===");

            string s = Console.ReadLine();
            string e = Console.ReadLine();
            int number1;
            int number2;
            bool rez1 = Int32.TryParse(s, out number1);
            bool rez2 = Int32.TryParse(e, out number2);
            Console.WriteLine("{0}-{1}", rez1, number1);
            Console.WriteLine("{0}-{1}", rez2, number2);

        }
        // Boolean Expression
        static void Task5()
        {
            Console.WriteLine("=== Task 5: Square Calculations ===");

            Console.WriteLine("Enter side of the square: ");
            int a = int.Parse(Console.ReadLine());

        int square = a * a;
        int perimeter = a + a + a + a;
        Console.WriteLine("\nResults:");
            Console.WriteLine($"Square = {square}");
            Console.WriteLine($"Perimeter = {perimeter}");

        }
        // Boolean Expression
        static void Task6()
        {
            Console.WriteLine("=== Task 6: Name and Age Interaction ===");

            Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();

    Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nYour name is {name} and you are {age} years old.");

        }
        // Boolean Expression
        static void Task7()
        {
            Console.WriteLine("=== Task 7: Circle Calculations ===");

            Console.WriteLine("Enter the radius of circle: ");
            double r = double.Parse(Console.ReadLine());

            double Length = 2 * Math.PI * r;
            double Area = Math.PI * r * r;
            double Volume = 4.0 / 3.0 * Math.PI * r * r * r;

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Length = {Length}");
            Console.WriteLine($"Area = {Area}");
            Console.WriteLine($"Volume = {Volume}");

        }
    }
}
