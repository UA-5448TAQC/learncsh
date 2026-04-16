

namespace Task6
{
    internal class Program
    {
        static void ReadTxtFiles(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path, "*.txt");
                string[] directories = Directory.GetDirectories(path);

                for (int i = 0; i < files.Length; i++)
                {
                    try
                    {
                        Console.WriteLine("File: " + files[i]);
                        Console.WriteLine(File.ReadAllText(files[i]));
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot read file " + files[i] + ": " + ex.Message);
                    }
                }

                for (int i = 0; i < directories.Length; i++)
                {
                    ReadTxtFiles(directories[i]);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied: " + path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + path + ": " + ex.Message);
            }
        }

        static void Main()
        {
            ReadTxtFiles(@"D:\");
        }
    }
}