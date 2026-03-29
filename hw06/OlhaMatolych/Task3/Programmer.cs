
namespace ConsoleApp1
{
    internal class Programmer(string language) : IDeveloper, IComparable<Programmer>
    {
        public string Language { get; set; } = language;

        public string Tool => "Computer";
        public void Create()
        {
            Console.WriteLine($"Programmer creates code using {Language}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer deletes code written in {Language}.");
        }
        public int CompareTo(Programmer? other)
        {
            if (other == null) return 0;
            return Language.CompareTo(other.Language);
        }
    }
}