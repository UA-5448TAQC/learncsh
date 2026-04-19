namespace Task4_2
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string text = File.ReadAllText("data.txt");
                File.WriteAllText("rez.txt", text);
                Console.WriteLine("The file was copied successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}
