namespace Task5;

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\";
        string outputFile = "DirectoryC.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                ProcessDirectory(path, writer);
            }

            Console.WriteLine("Good! Done!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void ProcessDirectory(string path, StreamWriter writer)
    {
        try
        {
            // Папки
            string[] directories = Directory.GetDirectories(path);

            foreach (string dir in directories)
            {
                writer.WriteLine($"Name: {dir}");
                writer.WriteLine("Type: Directory");
                writer.WriteLine();


                ProcessDirectory(dir, writer);
            }

            // Файли
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);

                writer.WriteLine($"Name: {info.Name}");
                writer.WriteLine("Type: File");
                writer.WriteLine($"Size: {info.Length} bytes");
                writer.WriteLine();
            }
        }
        catch (UnauthorizedAccessException)
        {

            writer.WriteLine($"Access denied: {path}");
        }
        catch (Exception ex)
        {
            writer.WriteLine($"Error: {ex.Message}");
        }
    }
}
