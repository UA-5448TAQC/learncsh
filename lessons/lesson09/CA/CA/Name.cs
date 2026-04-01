using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA
{
    public class Name
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; } = string.Empty;
        public Name(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = "Empty";
        }

        public string toString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
        public override int GetHashCode() { 
            return HashCode.Combine(FirstName, LastName, MiddleName);
        }
    }
}
