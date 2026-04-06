using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class Programmer : IDeveloper, IComparable<Programmer>
    {
        private string language;

        public Programmer(string language)
        {
            this.language = language;
        }

        public string Tool
        {
            get { return language; }
        }

        public void Create()
        {
            Console.WriteLine("Programmer creates code using " + language + ".");
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer destroys code using " + language + ".");
        }

        public int CompareTo(Programmer other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.Tool.CompareTo(other.Tool);
        }
    }
}
