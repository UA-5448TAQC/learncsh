
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<int> myColl = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myColl.Add(int.Parse(Console.ReadLine()));
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
                Console.WriteLine("Element -10 not found.");
            }
            myColl.RemoveAll(x => x > 20);
            Console.WriteLine("Collection after removing elements > 20:");
            PrintCollection(myColl);

            if (2 >= 0 && 2 <= myColl.Count)
                myColl.Insert(2, 1);

            if (5 >= 0 && 5 <= myColl.Count)
                myColl.Insert(5, -4);

            if (8 >= 0 && 8 <= myColl.Count)
                myColl.Insert(8, -3);
            else
                myColl.Add(-3);

            Console.WriteLine("Collection after insertions:");
            PrintCollection(myColl);

            myColl.Sort();
            Console.WriteLine("Sorted collection:");
            PrintCollection(myColl);
        }
        static void PrintCollection(List<int> collection)
        {
            foreach (int item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}