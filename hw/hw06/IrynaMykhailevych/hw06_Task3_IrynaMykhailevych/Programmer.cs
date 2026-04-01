using System;

namespace hw06_Task3_IrynaMykhailevych
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {

        public string Language { get; set; } = "";
        public string Tool { get; set; } = "";
        public void Create()
        {
            Console.WriteLine($"Programmer writes code in {Language} using {Tool}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer breaks production while writing code in {Language} using {Tool}");
        }

        public int CompareTo(IDeveloper? other)
        {
            if (other == null)
            {
                return 1;
            }

            return Tool.CompareTo(other.Tool);
        }
    }
    
}
