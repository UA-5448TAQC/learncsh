namespace Task2;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myColl = new List<int>();

        Console.WriteLine("Enter 10 integers:");

        // Заповнення колекції
        for (int i = 0; i < 10; i++)
        {
            myColl.Add(int.Parse(Console.ReadLine()));
        }

        // 1️⃣ Пошук позицій елемента -10
        Console.WriteLine("\nPositions of element -10:");

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
            Console.WriteLine("No elements -10 found.");
        }

        // 2️⃣ Видалення елементів > 20
        myColl.RemoveAll(x => x > 20);

        Console.WriteLine("\nCollection after removing elements > 20:");
        PrintCollection(myColl);

        // 3️⃣ Вставка нових елементів
        // ВАЖЛИВО: порядок вставки впливає на індекси
        myColl.Insert(2, 1);   // позиція 2
        myColl.Insert(5, -4);  // позиція 5
        myColl.Insert(8, -3);  // позиція 8

        Console.WriteLine("\nCollection after insertions:");
        PrintCollection(myColl);

        // 4️⃣ Сортування
        myColl.Sort();

        Console.WriteLine("\nSorted collection:");
        PrintCollection(myColl);
    }

    // Допоміжний метод для виводу
    static void PrintCollection(List<int> collection)
    {
        foreach (var item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}