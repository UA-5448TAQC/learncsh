
namespace ConsoleApp1
{
    internal class Builder(string tool) : IDeveloper, IComparable<Builder>
    {
        public string Tool { get; set; } = tool;
        public void Create()
        {
            Console.WriteLine($"Builder builds using {Tool}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder demolishes using {Tool}.");
        }
        public int CompareTo(Builder? other)
        {
            if (other == null) return 0;
            return Tool.CompareTo(other.Tool);
        }
    }
}
