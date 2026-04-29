using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task1.Run();
            Task2.Run();
            Task3.Run();
            Task4.Run();

            Console.WriteLine();
            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }
    }
}