using System;
using System.IO;

namespace hw08_IrynaMykhailevych
{
    internal class Task4
    {
        static void Run()
        {
            MethodStreamReader();
            MethodWriteAllText();
        }

        static void MethodStreamReader()
        {
            try
            {
                using (StreamReader reader = new StreamReader("data.txt"))
                using (StreamWriter writer = new StreamWriter("rez1.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Method 1 done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void MethodWriteAllText()
        {
            try
            {
                string content = File.ReadAllText("data.txt");
                File.WriteAllText("rez2.txt", content);
                Console.WriteLine("Method 2 done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
