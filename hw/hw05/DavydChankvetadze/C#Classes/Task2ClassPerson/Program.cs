using Task2ClassPerson.Entities;

namespace Task2ClassPerson;

internal class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[6];

        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person();
        }
        
        Console.WriteLine("Enter data for 6 persons:\n");

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine($"Person #{i + 1}:");
            people[i].Input();
            Console.WriteLine();
        }

        Console.WriteLine("Persons information:");
        foreach (Person person in people)
        {
            person.Output();
        }

        foreach (Person person in people)
        {
            if (person.Age() < 16)
            {
                person.ChangeName("Very Young");
            }
        }

        Console.WriteLine("\nUpdated information:");
        foreach (Person person in people)
        {
            person.Output();
        }

        Console.WriteLine("\nPersons with the same names:");
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
            Console.WriteLine("No persons with the same names were found.");
        }
    }
}
