namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myColl = new List<int>();

            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                myColl.Add(int.Parse(Console.ReadLine()));
            }

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
                Console.WriteLine("Element -10 not found.");
            }

            for (int i = myColl.Count - 1; i >= 0; i--)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                }
            }

            Console.WriteLine("After removing elements > 20:");
            PrintCollection(myColl);

            if (myColl.Count >= 2)
                myColl.Insert(2, 1);
            else
                myColl.Add(1);

            if (myColl.Count >= 5)
                myColl.Insert(5, -4);
            else
                myColl.Add(-4);

            if (myColl.Count >= 8)
                myColl.Insert(8, -3);
            else
                myColl.Add(-3);

            Console.WriteLine("After inserting elements:");
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
}
