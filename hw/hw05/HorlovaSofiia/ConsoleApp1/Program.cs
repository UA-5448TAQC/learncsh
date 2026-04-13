using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunTask1();
            InputHelper.PrintSeparator();
            RunTask2();

            Console.WriteLine();
            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }

        private static void RunTask1()
        {
            Console.WriteLine("Task 1 — Class Car");

            Car[] cars = new Car[3];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Enter data for car #{i + 1}:");
                cars[i] = new Car();
                cars[i].Input();
                InputHelper.PrintSeparator();
            }

            Console.WriteLine("Cars before price change:");
            foreach (Car car in cars)
            {
                car.Print();
            }

            InputHelper.PrintSeparator();

            Console.WriteLine("Cars after price decrease by 10%:");
            foreach (Car car in cars)
            {
                car.ChangePrice(-10);
                car.Print();
            }

            InputHelper.PrintSeparator();

            Console.WriteLine("Repaint white cars");
            string newColor = InputHelper.ReadNonEmptyString("Enter new color:");

            foreach (Car car in cars)
            {
                if (car.Color.Equals("white", StringComparison.OrdinalIgnoreCase))
                {
                    car.Color = newColor;
                }
            }

            Console.WriteLine("Cars after repaint:");
            foreach (Car car in cars)
            {
                car.Print();
            }

            InputHelper.PrintSeparator();

            if (cars[0] == cars[1])
            {
                Console.WriteLine("Car #1 and Car #2 are equal.");
            }
            else
            {
                Console.WriteLine("Car #1 and Car #2 are not equal.");
            }
        }

        private static void RunTask2()
        {
            Console.WriteLine("Task 2 — Class Person");

            Person[] persons = new Person[6];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter data for person #{i + 1}:");
                persons[i] = new Person();
                persons[i].Input();
                InputHelper.PrintSeparator();
            }

            Console.WriteLine("Persons (name and age):");
            foreach (Person person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age()}");
            }

            InputHelper.PrintSeparator();

            foreach (Person person in persons)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }

            Console.WriteLine("Updated persons:");
            foreach (Person person in persons)
            {
                person.Output();
            }

            InputHelper.PrintSeparator();

            Console.WriteLine("Persons with same names:");
            bool foundSameNames = false;

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine(persons[i]);
                        Console.WriteLine(persons[j]);
                        InputHelper.PrintSeparator();
                        foundSameNames = true;
                    }
                }
            }

            if (!foundSameNames)
            {
                Console.WriteLine("No persons with the same names found.");
            }
        }
    }
}