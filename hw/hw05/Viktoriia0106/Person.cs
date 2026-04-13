using System;

namespace ConsoleAppHW05
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person() { }

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
            name = Console.ReadLine().Trim().ToLower();
            Console.Write("Enter birth year (YYYY): ");
            int year = int.Parse(Console.ReadLine());
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person a, Person b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.name == b.name;
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }
    }
}
