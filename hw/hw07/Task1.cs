namespace Task1;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Person: {Name}");
    }
}

class Staff : Person
{
    public int Salary;

    public Staff(string name, int salary) : base(name)
    {
        Salary = salary;
    }

    public override void Print()
    {
        Console.WriteLine($"Staff: {Name}, Salary: {Salary}");
    }
}

class Teacher : Staff
{
    public string Subject;

    public Teacher(string name, string subject, int salary) : base(name, salary)
    {
        Subject = subject;
    }

    public override void Print()
    {
        Console.WriteLine($"Teacher: {Name}, Subject: {Subject}, Salary: {Salary}");
    }
}

class Developer : Staff
{
    public string Level;

    public Developer(string name, string level, int salary) : base(name, salary)
    {
        Level = level;
    }

    public override void Print()
    {
        Console.WriteLine($"Developer: {Name}, Level: {Level}, Salary: {Salary}");
    }
}

class Program
{
    static void Main()
    {
        // 1. Створюємо список людей
        List<Person> people = new List<Person>
        {
            new Person("John"),
            new Teacher("Alice", "Math", 700),
            new Teacher("Emma", "History", 720),
            new Developer("Bob", "Senior", 2000),
            new Developer("Mike", "Junior", 900)
        };

        // 2. Виводимо всіх
        Console.WriteLine("=== All people ===");
        foreach (Person p in people)
        {
            p.Print();
        }

        // 3. Пошук по імені
        Console.WriteLine();
        Console.Write("Enter name: ");
        string searchName = Console.ReadLine();

        Person foundPerson = null;

        foreach (Person p in people)
        {
            if (p.Name == searchName)
            {
                foundPerson = p;
                break;
            }
        }

        Console.WriteLine();
        if (foundPerson != null)
        {
            Console.WriteLine("=== Found person ===");
            foundPerson.Print();
        }
        else
        {
            Console.WriteLine("Person not found.");
        }

        // 4. Сортування по імені
        people.Sort((a, b) => a.Name.CompareTo(b.Name));

        Console.WriteLine();
        Console.WriteLine("=== Sorted by name ===");
        foreach (Person p in people)
        {
            p.Print();
        }

        // 5. Запис у файл
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            writer.WriteLine("=== Sorted by name ===");
            foreach (Person p in people)
            {
                if (p is Teacher teacher)
                {
                    writer.WriteLine($"Teacher: {teacher.Name}, Subject: {teacher.Subject}, Salary: {teacher.Salary}");
                }
                else if (p is Developer developer)
                {
                    writer.WriteLine($"Developer: {developer.Name}, Level: {developer.Level}, Salary: {developer.Salary}");
                }
                else
                {
                    writer.WriteLine($"Person: {p.Name}");
                }
            }
        }

        // 6. Advanced: тільки працівники
        List<Staff> employees = new List<Staff>();

        foreach (Person p in people)
        {
            if (p is Staff staff)
            {
                employees.Add(staff);
            }
        }

        // 7. Сортування працівників по зарплаті
        employees.Sort((a, b) => a.Salary.CompareTo(b.Salary));

        Console.WriteLine();
        Console.WriteLine("=== Employees sorted by salary ===");
        foreach (Staff s in employees)
        {
            s.Print();
        }
    }
}

