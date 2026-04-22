using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2;

internal class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("DATA.txt");

        foreach (var line in lines)
        {
            Console.WriteLine($"Length: {line.Length} - {line}");
        }

        var longest = lines.OrderByDescending(l => l.Length).First();
        var shortest = lines.OrderBy(l => l.Length).First();

        Console.WriteLine($"\nLongest: {longest}");
        Console.WriteLine($"Shortest: {shortest}");

        var withVar = lines
            .Where(l => Regex.IsMatch(l, @"\bvar\b", RegexOptions.IgnoreCase));

        Console.WriteLine("\nLines with 'var':");
        foreach (var l in withVar)
        {
            Console.WriteLine(l);
        }
    }
}