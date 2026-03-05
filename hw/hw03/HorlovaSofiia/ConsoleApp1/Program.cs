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
            Task5.Run();
            Task6.Run();
            Task7.Run();
            Task8.Run();
            Task9.Run();

            Console.WriteLine();
            Console.WriteLine("All tasks completed. Press any key to exit...");
            Console.ReadKey();
        }
    }
}