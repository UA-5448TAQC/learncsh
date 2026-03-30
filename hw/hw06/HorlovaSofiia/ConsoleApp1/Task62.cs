using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal static class Task62
    {
        public static void Run()
        {
            Console.WriteLine("Homework 6.2 — Collections");

            List<int> myColl = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int value = InputHelper.ReadInt($"Enter integer #{i + 1}:");
                myColl.Add(value);
            }

            Console.WriteLine("Positions of element -10:");
            bool found = false;

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Element -10 was not found.");
            }

            myColl.RemoveAll(x => x > 20);

            Console.WriteLine("Collection after removing elements > 20:");
            PrintCollection(myColl);

            InsertIfPossible(myColl, 1, 2);
            InsertIfPossible(myColl, -3, 8);
            InsertIfPossible(myColl, -4, 5);

            Console.WriteLine("Collection after insert operations:");
            PrintCollection(myColl);

            myColl.Sort();

            Console.WriteLine("Sorted collection:");
            PrintCollection(myColl);

            InputHelper.PrintSeparator();
        }

        private static void InsertIfPossible(List<int> collection, int value, int position)
        {
            if (position >= 0 && position <= collection.Count)
            {
                collection.Insert(position, value);
            }
            else
            {
                Console.WriteLine($"Cannot insert value {value} at position {position}. Current Count = {collection.Count}.");
            }
        }

        private static void PrintCollection(List<int> collection)
        {
            if (collection.Count == 0)
            {
                Console.WriteLine("Collection is empty.");
                return;
            }

            Console.WriteLine(string.Join(", ", collection));
        }
    }
}