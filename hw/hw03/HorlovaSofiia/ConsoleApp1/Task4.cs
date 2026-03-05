using System;

namespace ConsoleApp1
{
    internal static class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Task 4 — Struct Dog");

            Dog myDog = new Dog
            {
                Name = InputHelper.ReadNonEmptyString("Enter dog name:"),
                Mark = InputHelper.ReadNonEmptyString("Enter dog mark (breed):"),
                Age = InputHelper.ReadIntMin("Enter dog age (>= 0):", 0)
            };

            Console.WriteLine("Dog info:");
            Console.WriteLine(myDog.ToString());
            InputHelper.PrintSeparator();
        }
    }
}