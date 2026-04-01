using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA
{
    public class Person
    {
        Name name;
        public Adress Adress { get; set; }
        int Birthday { get; set; }
        public Person(string firstName, string lastName, string middleName, Adress adress, int birthday)
        {
            this.name = new Name(firstName, lastName, middleName);
            Adress = adress;
            Birthday = birthday;
        }
        public Person(string firstName, string lastName, Adress adress, int birthday)
        {
            this.name = new Name(firstName, lastName);
            Adress = adress;
            Birthday = birthday;
        }

        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Birthday;
        }
        public override int GetHashCode() { return name.GetHashCode(); }
        public override string ToString()
        {
            return $"{name.toString()}, {Adress.ToString()}, Age: {GetAge()}";

        }
    }
}
