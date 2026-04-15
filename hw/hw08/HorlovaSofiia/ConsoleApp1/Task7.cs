using System;

namespace ConsoleApp1
{
    internal static class Task7
    {
        public static void Run()
        {
            Console.WriteLine("Task 7 — PhoneBook with Dictionary");

            try
            {
                Dictionary<string, string> phoneBook = FileService.ReadPhoneBook("phones.txt");

                FileService.SaveOnlyPhoneNumbers(phoneBook, "Phones.txt");
                Console.WriteLine("Phone numbers were saved to Phones.txt");

                string name = InputHelper.ReadNonEmptyString("Enter name to search:");

                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"Phone: {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }

                FileService.SaveUpdatedPhoneBook(phoneBook, "New.txt");
                Console.WriteLine("Updated phone book was saved to New.txt");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Task 7 Error: {exception.Message}");
            }

            InputHelper.PrintSeparator();
        }
    }
}