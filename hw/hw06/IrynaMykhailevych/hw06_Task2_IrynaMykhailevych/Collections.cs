using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace hw06_Task2_IrynaMykhailevych
{
    internal class Collections
    {
        static void Main()
        {
            List<int> myColl = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int number;
                Console.WriteLine($"Enter number {i + 1}:");
                string input = Console.ReadLine();
                int.TryParse(input, out number);
                myColl.Add(number);
            }

            Console.WriteLine($"Positions of -10:");

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"After removing elements > 20:");

            for (int i = myColl.Count - 1; i >= 0; i--)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                }
            }

            foreach (int number in myColl)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            myColl.Insert(7, -3);
            myColl.Insert(4, -4);
            myColl.Insert(1, 1);

            Console.WriteLine($"After inserting:");

            foreach (int number in myColl)
            {
                Console.Write(number + " ");

            }
            Console.WriteLine();


            myColl.Sort();

            Console.WriteLine("After sorting:");

            foreach (int number in myColl)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
