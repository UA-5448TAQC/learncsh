using System;

namespace ConsoleApp1
{
    internal static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Task 2 — Text Processing & LINQ");

            string inputPath = "input_text.txt";

            if (!File.Exists(inputPath))
            {
                FileHelper.WriteLines(inputPath, CreateDefaultText());
            }

            string[] lines = FileHelper.ReadLines(inputPath);

            Console.WriteLine("Characters count per line:");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"Line {i + 1}: {lines[i].Length} chars");
            }

            string longestLine = lines
                .OrderByDescending(line => line.Length)
                .FirstOrDefault() ?? string.Empty;

            string shortestLine = lines
                .OrderBy(line => line.Length)
                .FirstOrDefault() ?? string.Empty;

            Console.WriteLine();
            Console.WriteLine($"Longest line: {longestLine}");
            Console.WriteLine($"Shortest line: {shortestLine}");

            Regex varRegex = new Regex(@"\bvar\b", RegexOptions.IgnoreCase);

            IEnumerable<string> linesWithVar = lines
                .Where(line => varRegex.IsMatch(line));

            Console.WriteLine();
            Console.WriteLine("Lines containing word 'var':");

            foreach (string line in linesWithVar)
            {
                Console.WriteLine(line);
            }

            FileHelper.WriteLines("lines_with_var.txt", linesWithVar);

            Console.WriteLine(new string('-', 60));
        }

        private static List<string> CreateDefaultText()
        {
            return new List<string>
            {
                "var number = 10;",
                "Console.WriteLine(number);",
                "This line does not contain target word.",
                "var text = \"Hello\";",
                "A very short line.",
                "Another line with VAR keyword in uppercase."
            };
        }
    }
}