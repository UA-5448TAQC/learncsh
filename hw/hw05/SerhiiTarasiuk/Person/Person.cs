using System;

namespace Person
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
            name = "Unknown";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - birthYear.Year;

            if (DateTime.Now.DayOfYear < birthYear.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public void Input()
        {
            name = Helpers.ProgramHelpers.ReadNonEmptyString("Enter name: ");

            while (true)
            {
                Console.Write("Enter birth date (yyyy-mm-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                {
                    birthYear = date;
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid date. Please enter a valid date.");
                Console.ResetColor();
            }
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
            Console.WriteLine(ToString());
        }

        public static bool operator == (Person a, Person b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;

            return a.name == b.name;
        }

        public static bool operator != (Person a, Person b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return this == other;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}