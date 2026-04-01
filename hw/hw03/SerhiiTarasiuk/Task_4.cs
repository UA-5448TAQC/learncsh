namespace ConsoleApp1
{
    internal class Task_4
    {
        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            public override string ToString()
            {
                return ($"Name: {Name}, Mark: {Mark}, Age: {Age}" +
                    $"\n / \\__\r\n(    @\\___\r\n /         O\r\n/   (_____/\r\n/_____/   U" +
                    $"\t\tWOOOF! WOOOF!");
            }
        }

        static void Main(string[] args)
        {
            Dog myDog = new Dog();

            myDog.Name = ReadName();
            myDog.Mark = ReadMark();
            myDog.Age = ReadAge();

            Console.WriteLine("\nDog information:");
            Console.WriteLine(myDog.ToString());
            Console.Read();
        }

        static string ReadName()
        {
            Console.WriteLine("Enter dog's name:");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("No name... Hmmm... I'll call your dog NULLchick");
                    return "NULLchick";
                }

                if (input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    return input;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input... Please enter a valid name.");
                Console.ResetColor();
            }
        }

        static string ReadMark()
        {
            Console.WriteLine("Enter dog's mark:");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("No mark... Hmmm... it is definitely Metis");
                    return "Metis";
                }

                if (input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    return input;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input... Please enter a valid mark.");
                Console.ResetColor();
            }
        }

        static int ReadAge()
        {
            Console.WriteLine("Enter dog's age:");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                    return age;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input... Please enter a valid age.");
                Console.ResetColor();
            }
        }
    }
}