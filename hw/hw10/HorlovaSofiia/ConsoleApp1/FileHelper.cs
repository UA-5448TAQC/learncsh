using System;

namespace ConsoleApp1
{
    internal static class FileHelper
    {
        public static void WriteLines(string path, IEnumerable<string> lines)
        {
            File.WriteAllLines(path, lines);
        }

        public static void WriteText(string path, string text)
        {
            File.WriteAllText(path, text);
        }

        public static string[] ReadLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void SerializeToJson<T>(string path, T obj)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(path, json);
        }

        public static T? DeserializeFromJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}