namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine().ToLower();

            int a = 0, o = 0, i = 0, e = 0;

            foreach (char c in str)
            {
                if (c == 'a') a++;
                if (c == 'o') o++;
                if (c == 'i') i++;
                if (c == 'e') e++;
            }

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"o: {o}");
            Console.WriteLine($"i: {i}");
            Console.WriteLine($"e: {e}");

        }
    }
}
k