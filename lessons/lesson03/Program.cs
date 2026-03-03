namespace ConsoleApp3
{
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    struct Student
    {
        public string Name;
        public int Age;
        public string City;

        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}, City: {2}", Name, Age, City);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //string str = "Hello\n Wor\tld";
            //Console.WriteLine(str);
            //string verbatimStr = @"Hello\n Wor\tld";
            //Console.WriteLine(verbatimStr);
            //string path = "C:\\Users\\JohnDoe\\Documents\file.txt";
            //Console.WriteLine(path);
            //string verbatimPath = @"C:\Users\JohnDoe\Documents\file.txt";
            //Console.WriteLine(verbatimPath);
            //string multiLine = @"This is a multi-line
            //    string literal that preserves
            //        the formatting and whitespace.";
            //Console.WriteLine(multiLine);
            //string text = "This is a \"hello!\"";
            //Console.WriteLine(text);
            //text = @"This is a ""hello!""";
            //Console.WriteLine(text);

            //int @static =10;
            //Console.WriteLine(@static);
            //int a;
            ////a = 5;
            //int b = 10;

            //int c = a+ b;
            //Console.WriteLine(c);
            //int a = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(a++);
            //Console.WriteLine(a);
            //Console.WriteLine(++a);
            //Console.WriteLine(a);
            //Console.WriteLine(a%2);
            //Console.WriteLine(" 7 % 3 = {0}", 7 % 3);
            //Console.WriteLine(" 7 % 4 = {0}", 7 % 4);
            //Console.WriteLine(" 7 % 5 = {0}", 7 % 5);

            //Console.WriteLine(true);
            //Console.WriteLine(!true);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && false);
            //Console.WriteLine(false || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || false);
            //string a = Console.ReadLine();
            //Console.WriteLine(a);
            //string text ;
            //text = int.Parse(a) > 100 ? "Greater than 100" : "Less than or equal to 100";
            //Console.WriteLine(text);

            //long a = 8990000000L;
            //Console.WriteLine(a);
            //int b = (int) a;
            //Console.WriteLine(b);

 

            //Days today = Days.Mon;
            //int dayNumber = (int)today;
            //Console.WriteLine("{0} is day number #{1}.", today, dayNumber);
            //today = Days.Sun;
            //dayNumber = (int)today;
            //Console.WriteLine("{0} is day number #{1}.", today, dayNumber);

            Student student1, student2, student3;
            student1.Name = "Alice";
            student1.Age = 20;
            student1.City = "New York";

            student2.Name = "Bob";
            student2.Age = 30;
            student2.City = "Los Angeles";

            student3.Name = "Charlie";
            student3.Age = 25;
            student3.City = "Chicago";

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Console.WriteLine("Total students: {0}", students.Count);
            Console.WriteLine(students);
            for (int i = 0; i < students.Count; i++)
            {
                students[i].DisplayInfo();
            }
        }
    }
}
