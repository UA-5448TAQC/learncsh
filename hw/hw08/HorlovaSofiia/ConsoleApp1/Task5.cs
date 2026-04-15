using System;

namespace ConsoleApp1
{
    internal static class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Task 5 — Directory Information");

            try
            {
                FileService.WriteDirectoryInfo(@"D:\", "DirectoryC.txt");
                Console.WriteLine("Directory information was written to DirectoryC.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            InputHelper.PrintSeparator();
        }
    }
}