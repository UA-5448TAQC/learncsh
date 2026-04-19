namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "data.txt";
            string outputFile = "rez.txt";

            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(inputFile);
                writer = new StreamWriter(outputFile);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }

                Console.WriteLine("File copied successfully using StreamReader and StreamWriter.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: data.txt not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied.");
            }
            catch (IOException exc)
            {
                Console.WriteLine($"I/O error: {exc.Message}");
            }
            finally
            {
                reader?.Close();
                writer?.Close();
                Console.WriteLine("Task 4.1 finished.");
            }
        }
    }
}