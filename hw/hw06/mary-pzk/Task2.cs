using System;
using System.Collections.Generic;

namespace HW06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers: ");

            List<int> myColl = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                myColl.Add(int.Parse(Console.ReadLine()));
            }

            bool found = false;

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    if (!found)
                    {
                        Console.WriteLine("\n-10 is found at the following indices:");
                    }

                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("\nThere is no -10 in the collection.");
            }


            Console.WriteLine("\nAll numbers greater than 20 will be removed.");
            for (int i = myColl.Count - 1; i >= 0; i--)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                }
            }

            Console.WriteLine("\nUpdated list after removing:");
            foreach (var item in myColl)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nNew items to be added:");
            myColl.Insert(7, -3);
            myColl.Insert(4, -4);
            myColl.Insert(1, 1);

            foreach (var item in myColl)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nItems after ascending sorting:");
            myColl.Sort();

            foreach (var item in myColl)
            {
                Console.WriteLine(item);
            }
        }
    }
}
