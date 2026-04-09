using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace hw5_Zoriana_Telychko
{
    internal class Person_task2
    {
        // Приватні поля — доступ лише через властивості або методи класу
        private string name;
        private DateTime birthYear;

        public string Name => name; // Лише геттер для імені — ім'я можна змінити тільки через метод ChangeName - expression-bodied property
        public DateTime BirthYear => birthYear;
        public Person_task2() { } //для створення об'єктів через Input()

        public Person_task2(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - birthYear.Year;
            if (DateTime.Today < birthYear.AddYears(age))
                age--;

            return age;
            // Якщо день народження ще не настав цього року — віднімаємо 1
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter birth date (yyyy-MM-dd): ");
            while (!DateTime.TryParse(Console.ReadLine(), out birthYear))
            {
                Console.Write("Invalid date. Try again (yyyy-MM-dd): ");
            }

        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        // ToString формує рядок з усіма даними об'єкта
        
        public override string ToString()
        {
            return $"Name: {name,-15} | Birth: {birthYear:yyyy-MM-dd} | Age: {Age()}"; 
            // Використовуємо форматування для вирівнювання імені та форматування дати
            // {name,-15} — вирівнювання імені по лівому краю з шириною 15 символів
        }

        // Output явно викликає ToString() — відповідно до вимоги завдання
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        // Особи вважаються "однаковими" якщо мають однакове ім'я
        public static bool operator ==(Person_task2 a, Person_task2 b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return string.Equals(a.name, b.name, StringComparison.OrdinalIgnoreCase); // Порівнюємо імена без урахування регістру
        }

        public static bool operator !=(Person_task2 a, Person_task2 b)
        {
            return !(a == b); // повторно використовуємо логіку ==
        }

        public override bool Equals(object obj)
        {
            if (obj is Person_task2 other)
                return this == other;
            return false;
        }

        // Хеш будується з того самого поля, що й порівняння (name)
        // Обов'язкова умова: якщо a == b, то a.GetHashCode() == b.GetHashCode()
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(name);
        }
    }
}
