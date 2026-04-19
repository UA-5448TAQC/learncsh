namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drivePath = @"D:\";
            string outputFile = "DirectoryC.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    WriteDirectoryInfo(drivePath, writer);
                }

                Console.WriteLine("Directory information saved to DirectoryC.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        static void WriteDirectoryInfo(string path, StreamWriter writer)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);
                    writer.WriteLine($"Name: {dirInfo.Name} | Type: Directory");
                    WriteDirectoryInfo(dir, writer);
                }
                foreach (string file in Directory.GetFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    writer.WriteLine($"Name: {fileInfo.Name} | Type: File | Size: {fileInfo.Length} bytes");
                }
            }
            catch (UnauthorizedAccessException)
            {
                writer.WriteLine($"Access denied: {path}");
            }
            catch (DirectoryNotFoundException)
            {
                writer.WriteLine($"Directory not found: {path}");
            }
            catch (IOException ex)
            {
                writer.WriteLine($"I/O error in {path}: {ex.Message}");
            }
        }
    }
}