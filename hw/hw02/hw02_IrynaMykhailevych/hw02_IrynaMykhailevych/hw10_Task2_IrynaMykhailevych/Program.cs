namespace hw10_Task2_IrynaMykhailevych
{
    internal class Program
    {
        static void Run()
        {
            var lines = File.ReadAllLines("text.txt");

            foreach (var line in lines)
            {
                Console.WriteLine($"{line} → {line.Length} symbols");
                Console.WriteLine();
            }

            var longestLine = lines.OrderBy(line => line.Length).Last();
            Console.WriteLine($"Longest line: {longestLine} → {longestLine.Length} symbols");
            Console.WriteLine();

            var shortestLine = lines.OrderBy(line => line.Length).First();
            Console.WriteLine($"Shortest line: {shortestLine} → {shortestLine.Length} symbols");
            Console.WriteLine();

            List<string> linesWithVar = lines.Where(line => line.ToLower().Contains("var")).ToList();
            Console.WriteLine($"Lines containing 'var': {linesWithVar.Count}");
            Console.WriteLine();

            foreach (var line in linesWithVar)
            {
                Console.WriteLine(line);
            }
        }
    }
}
