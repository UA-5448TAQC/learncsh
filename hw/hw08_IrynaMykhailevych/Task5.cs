using System;
using System.IO;

namespace hw08_IrynaMykhailevych
{
    internal class Task5
    {
        static void Run()
        {
            string startPath = @"C:\Test folder";
            string outputFile = "DirectoryC.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    WriteDirectoryInfo(startPath, writer);
                }
                Console.WriteLine("Information has been written to DirectoryC.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void WriteDirectoryInfo(string path, StreamWriter writer)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                foreach (string dir in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);

                    writer.WriteLine("---------------");
                    writer.WriteLine($"Name: {dirInfo.Name}");
                    writer.WriteLine("Type: Directory");
                }

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);

                    writer.WriteLine("---------------");
                    writer.WriteLine($"Name: {fileInfo.Name}");
                    writer.WriteLine("Type: File");
                    writer.WriteLine($"Size: {fileInfo.Length} bytes");
                }

                foreach (string dir in directories)
                {
                    WriteDirectoryInfo(dir, writer);
                }
            }
            catch (UnauthorizedAccessException)
            {
                writer.WriteLine($"Access denied: {path}");
            }
            catch (Exception ex)
            {
                writer.WriteLine($"Error accessing {path}: {ex.Message}");
            }
        }
    }
}
