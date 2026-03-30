using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task1
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string str = Console.ReadLine();

            int count = 0;
            foreach (char ch in str)
            {
                char lower = char.ToLower(ch);
                if (lower == 'a' || lower == 'o' || lower == 'i' || lower == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine("Total vowels: " + count);

            Console.ReadLine();
        }
    }
}
