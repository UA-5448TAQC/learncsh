
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Person[] persons = new Person[6];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter data for person {i + 1}:");

                persons[i] = new Person();
                persons[i].Input();

                Console.WriteLine();
            }

            Console.WriteLine("Persons and their ages:");

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"{persons[i].Name} - Age: {persons[i].Age()}");
            }

            Console.WriteLine();
            Console.WriteLine("Changing names for persons younger than 16:");

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age() < 16)
                {
                    persons[i].ChangeName("Very Young");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Updated persons:");

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            Console.WriteLine();
            Console.WriteLine("Persons with the same names:");

            bool foundSame = false;

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i].Name} appears more than once.");
                        foundSame = true;
                    }
                }
            }

            if (!foundSame)
            {
                Console.WriteLine("No persons with the same name.");
            }
        }
    }
}