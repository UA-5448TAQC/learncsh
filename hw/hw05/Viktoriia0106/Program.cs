using System;

namespace ConsoleAppHW05
{ class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Input();

            Person p2 = new Person();
            p2.Input();

            Person p3 = new Person();
            p3.Input();

            Person p4 = new Person();
            p4.Input();

            Person p5 = new Person();
            p5.Input();

            Person p6 = new Person();
            p6.Input();

            if (p1 == p2 && p1 == p3 && p1 == p4 && p1 == p5 && p1 == p6) 
            {
                Console.WriteLine("Same people (same name)" + p1.Name); 
                Console.WriteLine("Same people (same age)" + p1.Age());
            }

            else
                {
                    Console.WriteLine("Different paople");
                }
            Person[] people = { p1, p2, p3, p4, p5, p6 };
            foreach (Person p in people)
            {
                if (p.Age() < 16)
                {
                    p.ChangeName("Very Young");
                }
                p.Output();
            }
        }
        }
    }










