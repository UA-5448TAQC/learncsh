using System;

namespace ConsoleApp1
{
    internal static class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Task 6 — Read Only .txt Files");

            try
            {
                FileService.PrintTxtFilesContent(@"D:\");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            InputHelper.PrintSeparator();
        }
    }
}