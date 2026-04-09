using System;

// Namespace -> struct -> class -> fields and methods

namespace hw3_Zoriana_Telychko
{ 
    struct Dog
    {
        public string name;
        public string mark;
        public int age;
        public override string ToString()
        {
            return $"Dog's name: {name}, mark: {mark}, age: {age}";
        }
    }

    internal class Task4
    {
        static void Main(string[] args)
        {
            Dog myDog = new ();

            Console.WriteLine("Enter dog's name: ");
            myDog.name = Console.ReadLine();

            Console.WriteLine("Enter dog's mark: ");
            myDog.mark = Console.ReadLine();

            Console.WriteLine("Enter dog's age: ");
            string ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out int result) && result > 0)
            {
                myDog.age = result;
            }
            else
            {
                Console.WriteLine("Invalid age entered");
            }

            Console.WriteLine("\n<<<<<Dog information>>>>>");
            Console.WriteLine(myDog);
        }
    }
}