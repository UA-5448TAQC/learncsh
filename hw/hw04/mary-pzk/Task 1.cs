namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some value");
            string str = Console.ReadLine();
            int aCount = 0;
            int oCount = 0;
            int iCount = 0;
            int eCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == 'a' || c == 'A')
                {
                    aCount++;
                }

                if (c == 'o' || c == 'O')
                {
                    oCount++;
                }

                if (c == 'i' || c == 'I')
                {
                    iCount++;
                }

                if (c == 'e' || c == 'E')
                {
                    eCount++;
                }
            }
            Console.WriteLine($"There are {aCount} 'a' characters, {oCount} 'o' characters, {iCount} 'i' characters and {eCount} 'e' characters.");
        }
    }
}
