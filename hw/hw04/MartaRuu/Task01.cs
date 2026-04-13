namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter value: ");
            string str = Console.ReadLine();
            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;
            foreach (char c in str)
            {
                if (c == 'a' || c == 'A')
                    countA++;
                else if (c == 'o' || c == 'O')
                    countO++;
                else if (c == 'i' || c == 'I')
                    countI++;
                else if (c == 'e' || c == 'E')
                    countE++;
            }
            Console.WriteLine("a: " + countA);
            Console.WriteLine("o: " + countO);
            Console.WriteLine("i: " + countI);
            Console.WriteLine("e: " + countE);
        }
    }
}