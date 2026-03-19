using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace hw05_IrynaMykhailevych
{
    internal class ProgramPerson
    {
        public static void Run()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Person person5 = new Person();
            Person person6 = new Person();

            Person[] people = { person1, person2, person3, person4, person5, person6 };

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("---------------");
                Console.WriteLine($"Enter data for person {i + 1}:");
                people[i].Input();
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Initial data: ");
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

            Console.WriteLine("---------------");
            Console.WriteLine("Data after name change: ");
            foreach (Person person in people)
            {
                person.Output();
            }

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("Same names found: ");
                        people[i].Output();
                        people[j].Output();
                    }
                }
            }

        }
    }
}
