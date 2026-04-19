namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "data.txt";
            string outputFile = "rez.txt";

            try
            {
                string content = File.ReadAllText(inputFile);
                File.WriteAllText(outputFile, content);

                Console.WriteLine("File copied successfully using File.ReadAllText and File.WriteAllText.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: data.txt not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Task 4.2 finished.");
            }
        }
    }
}