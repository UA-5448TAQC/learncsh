namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        string str;

        while (true)
        {
            Console.Write("Enter a string (letters only): ");
            str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                continue;
            }

            bool containsDigits = false;

            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    containsDigits = true;
                    break;
                }
            }

            if (containsDigits)
            {
                Console.WriteLine("Input cannot contain digits. Please try again.");
                continue;
            }

            break;
        }

        str = str.ToLower();

        char[] vowels = { 'a', 'o', 'i', 'e' };
        int[] counts = new int[vowels.Length];

        foreach (char ch in str)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                if (ch == vowels[i])
                {
                    counts[i]++;
                }
            }
        }

        Console.WriteLine("\nOccurrences:");
        for (int i = 0; i < vowels.Length; i++)
        {
            Console.WriteLine($"{vowels[i]}: {counts[i]}");
        }

        int total = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            total += counts[i];
        }
        Console.WriteLine($"Total (a+o+i+e): {total}");
    }
}
