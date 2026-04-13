using System;

namespace ConsoleApp1
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public DateTime BirthYear
        {
            get
            {
                return birthYear;
            }
        }

        public Person()
        {
            name = string.Empty;
            birthYear = DateTime.Today;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - birthYear.Year;

            if (birthYear.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public void Input()
        {
            name = InputHelper.ReadNonEmptyString("Enter person name:");
            birthYear = InputHelper.ReadBirthDate("Enter birth date:");
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Name: {name}, Birth date: {birthYear:yyyy-MM-dd}, Age: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Person other)
            {
                return false;
            }

            return name == other.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }

        public static bool operator ==(Person? a, Person? b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.name == b.name;
        }

        public static bool operator !=(Person? a, Person? b)
        {
            return !(a == b);
        }
    }
}