using System;
namespace ConsoleAppVRHW06
{
    class Programmer : IDeveloper, IComparable
    {
        public string language;
        public string Tool { get; set; }

        public Programmer(string language, string tool)
        {
            this.language = language;
            this.Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Programmer creates code using {language}");
        }
        public void Destroy()
        {
            Console.WriteLine("Programmer deletes the bug.");
        }
        public int CompareTo(object obj)
        {
            IDeveloper other = (IDeveloper)obj;
            return this.Tool.CompareTo(other.Tool);
        }
    }
}