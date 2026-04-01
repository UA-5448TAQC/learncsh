namespace Person
{
    internal class ProgramPerson
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                Console.WriteLine($"\nEnter data for person {i + 1}:");
                people[i].Input();
            }

            Console.WriteLine("\n--- Persons: Name and Age ---");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age()}");
            }

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            Console.WriteLine("\n--- Updated information ---");
            foreach (Person person in people)
            {
                person.Output();
            }

            Console.WriteLine("\n--- Persons with same names ---");
            bool found = false;

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{people[i].Name} == {people[j].Name}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No persons with same names found.");
            }
        }
    }
}