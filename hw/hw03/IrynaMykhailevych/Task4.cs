using System;

namespace hw03_IrynaMykhailevych
{
    struct Dog
    {
        public string name;
        public string mark;
        public int age;
        public override string ToString()
        {
            return $"Dog's Name: {name}, Mark: {mark}, Age: {age}";
        }
    }
    internal class Task4
    {
        public static void Run()
        {
            Dog myDog = new Dog();

            Console.Write("Enter name: ");
            myDog.name = Console.ReadLine();

            Console.Write("Enter mark: ");
            myDog.mark = Console.ReadLine();

            Console.Write("Enter age: ");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out myDog.age) || myDog.age <= 0)
            {
                Console.Write("Invalid age. Enter a correct number: ");
                input = Console.ReadLine();
            }

            Console.WriteLine(myDog);
        }
    }
}
