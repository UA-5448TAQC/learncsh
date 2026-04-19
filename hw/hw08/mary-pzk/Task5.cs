using System;
using System.IO;

namespace Task5
{
    internal class Program
    {
        static void Main()
        {
            string path = @"D:\";
            string outputFile = "DirectoryC.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    ShowDirectory(path, writer);
                }

                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ShowDirectory(string path, StreamWriter writer)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                writer.WriteLine($"Name: {dirInfo.Name}, Type: Directory");

                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);

                    writer.WriteLine($"\tName: {info.Name}, Type: File, Size: {info.Length} bytes");
                }

                string[] dirs = Directory.GetDirectories(path);

                foreach (string dir in dirs)
                {
                    ShowDirectory(dir, writer);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied: {path}");
            }
        }
    }
}
