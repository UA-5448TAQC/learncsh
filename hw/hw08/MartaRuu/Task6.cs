namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drivePath = @"D:\";

            try
            {
                ReadTxtFiles(drivePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
        static void ReadTxtFiles(string path)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path, "*.txt"))
                {
                    try
                    {
                        Console.WriteLine($"File: {file}");
                        string content = File.ReadAllText(file);
                        Console.WriteLine(content);
                        Console.WriteLine();
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine($"Access denied to file: {file}");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"I/O error reading file {file}: {ex.Message}");
                    }
                }

                foreach (string dir in Directory.GetDirectories(path))
                {
                    ReadTxtFiles(dir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied to directory: {path}");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Directory not found: {path}");
            }
        }
    }
}
