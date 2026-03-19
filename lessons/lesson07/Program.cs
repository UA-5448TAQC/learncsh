namespace ConsoleApp4
{

    internal class Program
    {
        //public class Person
        //{
        //    private string name;

        //    public Person(string name)
        //    {
        //        this.name = name;
        //    }
        //    public string Name { get { return name; } }

        //    public void Print()
        //    {
        //        Console.WriteLine(">> Print Person <<");
        //        Console.WriteLine("\tName, {0}", Name);
        //    }
        //}

        //public class Staff : Person
        //{
        //    private int salary;
        //    public Staff(string name, int salary) : base(name)
        //    {
        //        this.salary = salary;
        //    }
        //    public int Salary { get { return salary; } }
        //    public string Name { get { return base.Name + "!"; } }
        //    public void Print()
        //    {
        //        Console.WriteLine(">> Print staff <<");
        //        base.Print();
        //        Console.WriteLine("\tSalary, {0}", salary);
        //    }


        //}

        public abstract class Person
        {
            //private string name;
            public Person(string name)
            {
                //this.name = name;
                Name = name;
            }
            public string Name { get; set; }
            public abstract void Print();
            public virtual void PrintName()
            {
                Console.WriteLine("Name: {0}", Name);
            }
        }

        class Staff : Person
        {
            private int salary;
            public Staff(string name, int salary) : base(name)
            {
                this.salary = salary;
            }
            public int Salary { get { return salary; } }
            public string Name { get { return base.Name + "!"; } }
            public override void Print()
            {
                Console.WriteLine(">> Print staff <<");
                Console.WriteLine("\tName, {0}", Name);
                Console.WriteLine("\tSalary, {0}", salary);
            }

            public sealed override void PrintName()
            {
                Console.WriteLine("Name from Staff: {0}", Name);
            }

            public void changeSalary(int newSalary)
            {
                salary = newSalary;
            }
        }

        class Teacher : Staff
        {
            public Teacher(string name, int salary) : base(name, salary)
            {
            }
            // This will cause a compile-time error since PrintName is sealed in Staff
            //public override void PrintName()
            //{
            //    Console.WriteLine("Name from Teacher: {0}", Name);
            //}

        }


        public sealed class Student : Person
        {
            private string school;
            public Student(string name, string school) : base(name)
            {
                this.school = school;
            }
            public string School { get; init; }
            public override void Print()
            {
                Console.WriteLine(">> Print student <<");
                Console.WriteLine("\tName, {0}", Name);
                Console.WriteLine("\tSchool, {0}", school);
            }

            public void PrintDepartment()
            {
                Console.WriteLine("Department: Computer Science");
            }
        }


        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////Person p1 = new Person("John");
            //Staff staff = new Staff("Alice", 50000);
            ////p1.Print();
            //staff.Print();
            //Console.WriteLine("Name from Person: {0}", staff.Name);
            //Person p2 = staff; // Upcasting
            //p2.Print();
            //Staff s = (Staff)p2; // Downcasting
            //s.Print();
            //s.PrintName();
            ////Staff s2 = (Staff)p1; // Safe downcasting - will throw an exception at runtime
            ///
            List<Person> people = new List<Person>();
            people.Add(new Staff("Alice", 50000));
            people.Add(new Student("Bob", "XYZ University"));
            people.Add(new Staff("Charlie", 60000));
            people.Add(new Student("Diana", "ABC College"));

            foreach (Person person in people)
            {
                Console.WriteLine(">> Printing Person <<");
                person.Print();
                person.PrintName();
                //person.PrintDepartment(); // This will cause a compile-time error since PrintDepartment is not defined in the Person class
                if (person is Student student)
                {
                    student.PrintDepartment(); // This will work since staff is of type Student
                }
                if (person is Staff staff)
                {
                    staff.changeSalary(staff.Salary + 5000); // Increase salary by 5000
                    Console.WriteLine("Updated Salary for {0}: {1}", staff.Name, staff.Salary);
                    staff.Print(); // This will call the overridden PrintName method in Staff
                }
                Console.WriteLine();

            }
        }
    }
}
