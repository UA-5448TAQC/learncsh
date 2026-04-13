using System;

namespace hw06_Task3_IrynaMykhailevych
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {

        public string Tool { get; set; } = "";
        public void Create() 
        {
            Console.WriteLine($"Builder builds a house using {Tool}");
        }

        public void Destroy() 
        {
            Console.WriteLine($"Builder destroys walls using {Tool}");
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
