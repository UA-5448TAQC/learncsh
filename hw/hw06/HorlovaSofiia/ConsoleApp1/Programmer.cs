using System;
namespace ConsoleApp1
{
    internal class Programmer : IDeveloper, IComparable<Programmer>
    {
        private readonly string language;

        public Programmer(string language)
        {
            this.language = language;
        }

        public string Tool
        {
            get
            {
                return language;
            }
        }

        public void Create()
        {
            Console.WriteLine($"Programmer creates code using {language}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer deletes code written in {language}.");
        }

        public int CompareTo(Programmer? other)
        {
            if (other is null)
            {
                return 1;
            }

            return string.Compare(language, other.language, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"Programmer: {language}";
        }
    }
}