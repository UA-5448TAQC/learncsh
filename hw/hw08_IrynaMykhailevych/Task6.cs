using System;
using System.IO;

namespace hw08_IrynaMykhailevych
{
    internal class Task6
    {
        static void Run()
        {
            string startPath = @"C:\Test folder";

            try
            {
                ReadTxtFiles(startPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ReadTxtFiles(string path)
        {
            try
            {
                string[] txtFiles = Directory.GetFiles(path, "*.txt");

                foreach (string file in txtFiles)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine($"File: {file}");

                    string content = File.ReadAllText(file);
                    Console.WriteLine(content);
                }

                string[] directories = Directory.GetDirectories(path);

                foreach (string dir in directories)
                {
                    ReadTxtFiles(dir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in {path}: {ex.Message}");
            }
        }
    }
}
