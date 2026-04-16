
namespace Task5
{
    internal class Program
    {
        static void WriteDirectoryInfo(string path, StreamWriter writer)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                for (int i = 0; i < directories.Length; i++)
                {
                    writer.WriteLine("Name: " + directories[i]);
                    writer.WriteLine("Type: Directory");
                    writer.WriteLine();
                }

                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo fileInfo = new FileInfo(files[i]);

                    writer.WriteLine("Name: " + fileInfo.FullName);
                    writer.WriteLine("Type: File");
                    writer.WriteLine("Size: " + fileInfo.Length + " bytes");
                    writer.WriteLine();
                }

                for (int i = 0; i < directories.Length; i++)
                {
                    WriteDirectoryInfo(directories[i], writer);
                }
            }
            catch (UnauthorizedAccessException)
            {
                writer.WriteLine("Access denied: " + path);
                writer.WriteLine();
            }
            catch (Exception ex)
            {
                writer.WriteLine("Error in " + path + ": " + ex.Message);
                writer.WriteLine();
            }
        }

        static void Main()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("DirectoryC.txt"))
                {
                    WriteDirectoryInfo(@"D:\", writer);
                }

                Console.WriteLine("Directory information saved to DirectoryC.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}