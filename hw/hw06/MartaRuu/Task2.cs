namespace ConsoleApp3
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
            Console.WriteLine("Positions of element -10:");
            bool found = false;
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("No element -10 found.");
            else
                Console.WriteLine();
            myColl.RemoveAll(x => x > 20);
            Console.WriteLine("Collection after removing elements > 20:");
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




