using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal static class Task63
    {
        public static void Run()
        {
            Console.WriteLine("Homework 6.3 — Interface IDeveloper");

            List<IDeveloper> developers = new List<IDeveloper>
            {
                new Programmer("C#"),
                new Programmer("Python"),
                new Programmer("Java"),
                new Builder("Hammer"),
                new Builder("Drill"),
                new Builder("Saw")
            };

            Console.WriteLine("Create/Destroy:");
            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }

            List<Programmer> programmers = new List<Programmer>();
            List<Builder> builders = new List<Builder>();

            foreach (IDeveloper developer in developers)
            {
                if (developer is Programmer programmer)
                {
                    programmers.Add(programmer);
                }
                else if (developer is Builder builder)
                {
                    builders.Add(builder);
                }
            }

            programmers.Sort();
            builders.Sort();

            Console.WriteLine("Sorted programmers:");
            foreach (Programmer programmer in programmers)
            {
                Console.WriteLine(programmer);
            }

            Console.WriteLine("Sorted builders:");
            foreach (Builder builder in builders)
            {
                Console.WriteLine(builder);
            }

            InputHelper.PrintSeparator();
        }
    }
}