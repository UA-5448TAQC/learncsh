using System;
using System.Collections.Generic;
using System.IO;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "phones.txt";
            string numbersFile = "Phones.txt";
            string updatedFile = "New.txt";

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                if (!File.Exists(inputFile))
                {
                    throw new FileNotFoundException("File phones.txt was not found.");
                }

                string[] lines = File.ReadAllLines(inputFile);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length != 2)
                    {
                        throw new Exception("Each line must contain exactly 2 values: Name and Phone Number.");
                    }

                    string name = parts[0];
                    string phoneNumber = parts[1];

                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, phoneNumber);
                    }

                }

                using (StreamWriter writer = new StreamWriter(numbersFile))
                {
                    foreach (var pair in phoneBook)
                    {
                        writer.WriteLine(pair.Value);
                    }
                }

                Console.Write("Enter a name to search: ");
                string searchName = Console.ReadLine();

                if (phoneBook.ContainsKey(searchName))
                {
                    Console.WriteLine("Phone number: " + phoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }

                Dictionary<string, string> updatedPhoneBook = new Dictionary<string, string>();

                foreach (var pair in phoneBook)
                {
                    string updatedNumber = UpdatePhoneNumber(pair.Value);
                    updatedPhoneBook.Add(pair.Key, updatedNumber);
                }

                using (StreamWriter writer = new StreamWriter(updatedFile))
                {
                    foreach (KeyValuePair<string, string> pair in updatedPhoneBook)
                    {
                        writer.WriteLine(pair.Key + " " + pair.Value);
                    }
                }

                Console.WriteLine("Phone numbers were saved to Phones.txt");
                Console.WriteLine("Updated data were saved to New.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }
        }

        static string UpdatePhoneNumber(string phoneNumber)
        {
            if (!phoneNumber.StartsWith("80"))
            {
                throw new Exception("Phone number must start with 80: " + phoneNumber);
            }

            if (phoneNumber.Length != 11)
            {
                throw new Exception("Phone number must contain 11 digits: " + phoneNumber);
            }

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    throw new Exception("Phone number must contain only digits: " + phoneNumber);
                }
            }

            return "+3" + phoneNumber;
        }
    }
}
