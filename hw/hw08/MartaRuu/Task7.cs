namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "phones.txt";
            string numbersOnlyFile = "Phones.txt";
            string updatedFile = "New.txt";

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                ReadPhoneBook(inputFile, phoneBook);
                SaveOnlyPhoneNumbers(phoneBook, numbersOnlyFile);
                Console.Write("Enter a name to search: ");
                string name = Console.ReadLine();
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"Phone number: {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }
                UpdatePhoneNumbers(phoneBook);
                SaveUpdatedPhoneBook(phoneBook, updatedFile);

                Console.WriteLine("Updated phone book saved to New.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: phones.txt not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Task 7 finished.");
            }
        }
        static void ReadPhoneBook(string fileName, Dictionary<string, string> phoneBook)
        {
            string[] lines = File.ReadAllLines(fileName);

            int count = 0;
            foreach (string line in lines)
            {
                if (count == 9)
                    break;

                string[] parts = line.Split(new[] { ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {
                    string name = parts[0];
                    string phone = parts[1];

                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, phone);
                        count++;
                    }
                }
            }
        }
        static void SaveOnlyPhoneNumbers(Dictionary<string, string> phoneBook, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var pair in phoneBook)
                {
                    writer.WriteLine(pair.Value);
                }
            }
        }
        static void UpdatePhoneNumbers(Dictionary<string, string> phoneBook)
        {
            List<string> keys = new List<string>(phoneBook.Keys);

            foreach (string key in keys)
            {
                string phone = phoneBook[key];

                if (phone.StartsWith("80"))
                {
                    phoneBook[key] = "+3" + phone;
                }
            }
        }
        static void SaveUpdatedPhoneBook(Dictionary<string, string> phoneBook, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var pair in phoneBook)
                {
                    writer.WriteLine($"{pair.Key} {pair.Value}");
                }
            }
        }
    }
}
