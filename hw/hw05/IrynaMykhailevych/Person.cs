using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw05_IrynaMykhailevych
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name 
        { 
            get { return name; } 
        }

        public DateTime BirthYear 
        { 
            get { return birthYear; }
        }

        public Person()
        {
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }
        
        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth year (yyyy): ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > DateTime.Now.Year)
            {
                Console.Write("Invalid input. Please enter a valid birth year (yyyy): ");
            }
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString() 
        {
            return $"Name: {Name}, Age: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;

            if (p1 is null || p2 is null)
                return false;

            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return name == other.name;
            return false;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
