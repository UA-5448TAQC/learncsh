using System;

namespace ConsoleApp1
{
    internal static class FileService
    {
        public static void SavePeopleToFile(string path, List<Person> people)
        {
            List<string> lines = people
                .Select(person => person.ToString())
                .ToList();

            File.WriteAllLines(path, lines);
        }
    }
}