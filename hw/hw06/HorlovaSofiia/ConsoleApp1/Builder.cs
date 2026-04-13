using System;
namespace ConsoleApp1
{
    internal class Builder : IDeveloper, IComparable<Builder>
    {
        private readonly string tool;

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool
        {
            get
            {
                return tool;
            }
        }

        public void Create()
        {
            Console.WriteLine($"Builder creates with {tool}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder destroys with {tool}.");
        }

        public int CompareTo(Builder? other)
        {
            if (other is null)
            {
                return 1;
            }

            return string.Compare(tool, other.tool, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"Builder: {tool}";
        }
    }
}