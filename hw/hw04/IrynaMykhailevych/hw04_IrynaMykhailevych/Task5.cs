using System;

namespace hw04_IrynaMykhailevych
{
    internal class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            if (text.Length < 2)
            {
                Console.WriteLine("The text must contain at least 2 characters.");
                return;
            }

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }
        }
    }
} 
