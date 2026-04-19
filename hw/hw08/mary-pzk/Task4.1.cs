using System.IO;
using System.Linq.Expressions;

namespace Task4_1
{
    internal class Program
    {
        static void Main()
        {

            string line;

            try
            {
                using (StreamReader reader = new StreamReader("data.txt"))

                using (StreamWriter writer = new StreamWriter("rez.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }
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
