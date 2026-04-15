using System;

namespace ConsoleApp1
{
    internal static class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Task 4 — File Read & Write");

            try
            {
                FileService.CopyFileLineByLine("data.txt", "rez_stream.txt");
                Console.WriteLine("4.1 StreamReader/StreamWriter copy completed.");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"4.1 Error: {exception.Message}");
            }

            try
            {
                FileService.CopyFileAsText("data.txt", "rez_file.txt");
                Console.WriteLine("4.2 File.ReadAllText/File.WriteAllText copy completed.");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"4.2 Error: {exception.Message}");
            }

            InputHelper.PrintSeparator();
        }
    }
}