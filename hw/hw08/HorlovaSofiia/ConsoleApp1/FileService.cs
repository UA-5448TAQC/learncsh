using System;

namespace ConsoleApp1
{
    internal static class FileService
    {
        public static void CopyFileLineByLine(string sourcePath, string destinationPath)
        {
            using StreamReader reader = new StreamReader(sourcePath);
            using StreamWriter writer = new StreamWriter(destinationPath, false);

            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
        }

        public static void CopyFileAsText(string sourcePath, string destinationPath)
        {
            string content = File.ReadAllText(sourcePath);
            File.WriteAllText(destinationPath, content);
        }

        public static void WriteDirectoryInfo(string rootPath, string outputPath)
        {
            using StreamWriter writer = new StreamWriter(outputPath, false);

            if (!Directory.Exists(rootPath))
            {
                writer.WriteLine($"Directory {rootPath} does not exist.");
                return;
            }

            WriteDirectoryRecursive(rootPath, writer);
        }

        private static void WriteDirectoryRecursive(string path, StreamWriter writer)
        {
            try
            {
                foreach (string directory in Directory.GetDirectories(path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                    writer.WriteLine(
                        $"Name: {directoryInfo.FullName} | Type: Directory");

                    WriteDirectoryRecursive(directory, writer);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    writer.WriteLine(
                        $"Name: {fileInfo.FullName} | Type: File | Size: {fileInfo.Length} bytes");
                }
            }
            catch (UnauthorizedAccessException exception)
            {
                writer.WriteLine($"Access denied: {path} | {exception.Message}");
            }
            catch (IOException exception)
            {
                writer.WriteLine($"I/O error: {path} | {exception.Message}");
            }
        }

        public static void PrintTxtFilesContent(string rootPath)
        {
            if (!Directory.Exists(rootPath))
            {
                Console.WriteLine($"Directory {rootPath} does not exist.");
                return;
            }

            string[] txtFiles = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

            if (txtFiles.Length == 0)
            {
                Console.WriteLine("No .txt files found.");
                return;
            }

            foreach (string filePath in txtFiles)
            {
                try
                {
                    Console.WriteLine($"File: {filePath}");
                    Console.WriteLine(File.ReadAllText(filePath));
                    Console.WriteLine(new string('-', 40));
                }
                catch (UnauthorizedAccessException exception)
                {
                    Console.WriteLine($"Access denied: {filePath} | {exception.Message}");
                }
                catch (IOException exception)
                {
                    Console.WriteLine($"I/O error: {filePath} | {exception.Message}");
                }
            }
        }

        public static Dictionary<string, string> ReadPhoneBook(string sourcePath)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            foreach (string line in File.ReadAllLines(sourcePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {
                    string name = parts[0];
                    string phone = parts[1];

                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, phone);
                    }
                }
            }

            return phoneBook;
        }

        public static void SaveOnlyPhoneNumbers(
            Dictionary<string, string> phoneBook,
            string outputPath)
        {
            File.WriteAllLines(outputPath, phoneBook.Values);
        }

        public static void SaveUpdatedPhoneBook(
            Dictionary<string, string> phoneBook,
            string outputPath)
        {
            List<string> lines = phoneBook
                .Select(pair => $"{pair.Key} {ConvertPhoneFormat(pair.Value)}")
                .ToList();

            File.WriteAllLines(outputPath, lines);
        }

        public static string ConvertPhoneFormat(string phone)
        {
            if (phone.StartsWith("80") && phone.Length == 11)
            {
                return "+3" + phone;
            }

            return phone;
        }
    }
}