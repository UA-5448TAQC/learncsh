using System.ComponentModel;

namespace ConsoleApp5
{
    internal class Program
    {

        class Person
        {
            public static int count = 0;
            int id { get; }
            string Name { get; set; }

            private string _surname;
            public string Surname
            {
                get
                {
                    Console.WriteLine("Surname get called");
                    return "Name:" + _surname;
                }
                set
                {
                    Console.WriteLine("Surname set called");
                    _surname = value + ".";
                }
            }
            int Age = 18;
            string email = "test@test.com";
            readonly string country = "Azerbaijan";

            public Person() { 
                count++;
                id = count;
                Console.WriteLine("Person created id:"+ id );
            }
            public Person(string _country): this() 
            {
                
                //count++;
                //id = count;
                country = _country;
                Console.WriteLine("Person created id:" + id);
            }

            public Person(string name, string surname, int age, string email, string country): this(country) 
            {
                //count++;
                //id = count;
                Name = name;
                Surname = surname;
                Age = age;
                this.email = email;
                //this.country = country;
            }
            public void Print() {
                //country = "Turkey"; // readonly field cannot be assigned to (except in a constructor or a variable initializer)
                Console.WriteLine("Id: " + id);
                Console.WriteLine("\tName: " + Name);
                Console.WriteLine("\tSurname: " + Surname);
                Console.WriteLine("\tAge: " + Age);
                Console.WriteLine("\tEmail: " + email);
                Console.WriteLine("\tCountry: " + country);
            }

            public string getSortInfo(string prefix)
            {
                return prefix +  "Id: " + id + ", Name: " + Name + ", Surname: " + Surname;
            }

            public string refShortInfo(ref string prefix)
            {
                prefix = prefix + "Id: " + id + ", Name: " + Name + ", Surname: " + Surname;
                return "prefix";
            }
            public string ShortInfo(string prefix)
            {
                prefix = prefix + "Id: " + id + ", Name: " + Name + ", Surname: " + Surname;
                return prefix;
            }
            public static bool operator < (Person p1, Person p2)
            {
                return p1.Age > p2.Age;
            }
            public static bool operator > (Person p1, Person p2)
            {
                return p1.Age < p2.Age;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Person count: " + Person.count);

            Person person1 = new Person();
            Console.WriteLine("Person count: " + Person.count);
            Person person2 = new Person();
            Console.WriteLine("Person count: " + Person.count);
            Person person3 = new Person("Ukraine");

            //Console.WriteLine(person1.id);
            //Console.WriteLine(person2.id);

            person3.Surname = "Smith";
            person1.Print();
            person2.Print();
            person3.Print();

            Console.WriteLine("Person count: " + Person.count);

            Person person4 = new Person("John", "Doe", 30, "test@gmail.com", "USA");
            person4.Print();
            Console.WriteLine(person4.getSortInfo("Person info: "));
            Console.WriteLine(person3.getSortInfo("Person info: "));
            Console.WriteLine(person2.getSortInfo("Person info: "));
            Console.WriteLine(person1.getSortInfo("Person info: "));
            string prefix = "Person info: ";
            Console.WriteLine(prefix);
            Console.WriteLine("============================");
            string result = person4.ShortInfo(prefix);
            Console.WriteLine($"result: {result}");
            Console.WriteLine($"prefix: {prefix}");
            Console.WriteLine("============================");
            //result = person4.refShortInfo(prefix);
            Console.WriteLine($"result: {result}");
            Console.WriteLine($"prefix: {prefix}");
            Console.WriteLine(person4 > person3);

        }
    }
}
