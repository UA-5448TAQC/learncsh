using System;

namespace HW06
{
    public class Builder : IDeveloper
    {
        public string Tool { get; set; }

        public Builder(string tool)
        {
            Tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"\nBuilder creates something using {Tool}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder destroys something using {Tool}.");

        }

        public int CompareTo(object obj)
        {
            IDeveloper other = (IDeveloper)obj;
            return Tool.CompareTo(other.Tool);
        }
    }
}