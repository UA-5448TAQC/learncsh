using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_Zoriana_Telychko
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            const int count = 6;
            Person_task2[] persons = new Person_task2[count];

            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Person {i + 1} ---");
                persons[i] = new Person_task2();
                persons[i].Input();
            }

            
            Console.WriteLine("\n--- All persons ---");
            foreach (Person_task2 p in persons) 
            {
                Console.WriteLine($"Name: {p.Name} | Age: {p.Age()}");
            }

            foreach (Person_task2 p in persons)
            {
                if (p.Age() < 16)
                    p.ChangeName("Very Young");
            }

            
            Console.WriteLine("\n--- Updated info ---");
            foreach (Person_task2 p in persons)
            {
                p.Output();
            }

            
            Console.WriteLine("\n---> Persons with same names <---");
            bool foundSameNames = false;

            for (int i = 0; i < count; i++) // Compare each person with the others
            {
                for (int j = i + 1; j < count; j++) // Avoid comparing the same pair twice
                {
                    if (persons[i] == persons[j]) // Using the overridden Equals method
                    {
                        Console.WriteLine($"Match found:");
                        Console.WriteLine($"  [{i + 1}] {persons[i]}");
                        Console.WriteLine($"  [{j + 1}] {persons[j]}");
                        foundSameNames = true;
                    }
                }
            }

            if (!foundSameNames)
                Console.WriteLine("No persons with the same name found.");
        }
    }
}
