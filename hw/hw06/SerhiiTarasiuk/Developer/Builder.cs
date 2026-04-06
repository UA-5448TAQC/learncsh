using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class Builder : IDeveloper, IComparable<Builder>
    {
        private string tool;

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool
        {
            get { return tool; }
        }

        public void Create()
        {
            Console.WriteLine("Builder creates using " + tool + ".");
        }

        public void Destroy()
        {
            Console.WriteLine("Builder destroys using " + tool + ".");
        }

        public int CompareTo(Builder other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.Tool.CompareTo(other.Tool);
        }
