using System;
using System.Collections.Generic;
using System.IO;

namespace hw08_IrynaMykhailevych
{
    internal class Task7
    {
        static void Run()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            LoadFromFile(phoneBook);
            SavePhones(phoneBook);
            Search(phoneBook);
            UpdatePhones(phoneBook);
        }

        static void LoadFromFile(Dictionary<string, string> phoneBook)
        {
            string[] lines = File.ReadAllLines("phones.txt");

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split(' ');

                if (parts.Length >= 2)
                {
                    phoneBook[parts[0]] = parts[1];
                }
            }
        }

        static void SavePhones(Dictionary<string, string> phoneBook)
        {
            File.WriteAllLines("OnlyPhones.txt", phoneBook.Values);
        }

        static void Search(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Name not found");
            }
        }

        static void UpdatePhones(Dictionary<string, string> phoneBook)
        {
            List<string> updatedLines = new List<string>();

            foreach (var item in phoneBook)
            {
                string updatedPhone = item.Value;

                if (updatedPhone.StartsWith("80"))
                {
                    updatedPhone = "+3" + updatedPhone;
                }

                updatedLines.Add($"{item.Key} {updatedPhone}");
            }

            File.WriteAllLines("New.txt", updatedLines);
        }
    }
}
