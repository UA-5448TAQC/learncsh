using System;
namespace ConsoleAppVRHW06
{
    class Builder : IDeveloper, IComparable
    {
        public string tool;
        public string Tool { get; set; }

        public Builder(string tool)
        {
            this.tool = tool;
            this.Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Builder builds using {tool}");
        }
        public void Destroy()
        {
            Console.WriteLine("Builder dismantled the structure."); 
        }
        public int CompareTo(object obj)
        {
            IDeveloper other = (IDeveloper)obj;
            return this.Tool.CompareTo(other.Tool);
        }
    }
}