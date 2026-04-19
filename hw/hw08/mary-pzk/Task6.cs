using System;
using System.IO;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\";

            try
            {
                string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    try
                    {
                        Console.WriteLine($"File: {file}");

                        string content = File.ReadAllText(file);
                        Console.WriteLine(content);
                        Console.WriteLine("\nNext file:\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n[ERROR]");
                        Console.WriteLine($"File: {file}");
                        Console.WriteLine($"Message: {ex.Message}");
                        Console.WriteLine("\nNext file:\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while searching files.");
                Console.WriteLine($"Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }
        }
    }
}
