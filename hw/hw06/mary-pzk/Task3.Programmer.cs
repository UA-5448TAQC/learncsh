using System;

namespace HW06
{
    public class Programmer : IDeveloper
    {
        private string language;
        public string Tool { get; set; }

        public Programmer(string lang)
        {
            language = lang;
            Tool = lang;
        }
        public void Create()
        {
            Console.WriteLine($"\nProgrammer creates code using {Tool}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer destroys code using {Tool}.");
        }

        public int CompareTo(object obj)
        {
            IDeveloper other = (IDeveloper)obj;
            return Tool.CompareTo(other.Tool);
        }

    }
}
 