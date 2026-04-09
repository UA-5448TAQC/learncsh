namespace Task6;

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\";

        try
        {
            ReadTxtFiles(path);
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
            // 🔹 Отримуємо всі .txt файли
            string[] files = Directory.GetFiles(path, "*.txt");

            foreach (string file in files)
            {
                Console.WriteLine($"- {file} -");

                string content = File.ReadAllText(file);
                Console.WriteLine(content);
                Console.WriteLine();
            }

            // 🔹 Заходимо в підпапки
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
