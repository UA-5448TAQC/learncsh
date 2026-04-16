
namespace Task7
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                string[] lines = File.ReadAllLines("phones.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        string phone = parts[1];
                        phoneBook[name] = phone;
                    }
                }

                using (StreamWriter writer = new StreamWriter("Phones.txt"))
                {
                    foreach (KeyValuePair<string, string> pair in phoneBook)
                    {
                        writer.WriteLine(pair.Value);
                    }
                }

                Console.Write("Enter name: ");
                string searchName = Console.ReadLine();

                if (phoneBook.ContainsKey(searchName))
                {
                    Console.WriteLine("Phone: " + phoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }

                using (StreamWriter writer = new StreamWriter("New.txt"))
                {
                    foreach (KeyValuePair<string, string> pair in phoneBook)
                    {
                        string phone = pair.Value;

                        if (phone.StartsWith("80"))
                        {
                            phone = "+3" + phone;
                        }

                        writer.WriteLine(pair.Key + " " + phone);
                    }
                }

                Console.WriteLine("Phone numbers saved to Phones.txt and New.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: phones.txt not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}