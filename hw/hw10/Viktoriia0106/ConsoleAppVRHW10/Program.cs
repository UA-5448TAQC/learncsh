using ConsoleAppVRHW10;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ConsoleAppVRHW10
{
    public delegate void MyDel(int m);
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapeList = ExecuteTask10_1();
            //ExecuteTask10_2();
            ExecuteTask10_4();

            // Task 10_3_In Main() block: Create objects 'Student', 'Parent', and 'Accountancy' 
            Student student = new Student { Name = "Viktoriia" };
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();
            // Subscribe Parent and Accountancy to the Student's MarkChange event
            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;
            // Add marks to the student and observe the event notifications
            student.AddMark(85); // This should notify both Parent and Accountancy
            student.AddMark(92); // This should notify both Parent and Accountancy, and Accountancy should award a fellowship
        }
        static List<Shape> ExecuteTask10_1()
        {
            List<Shape> shape = new List<Shape>();
            shape.Add(new Circle("FirstCircle", 10.5));
            shape.Add(new Square("FirstSquare", 12.2));
            shape.Add(new Circle("SmallCircle", 3.0));
            shape.Add(new Square("BigSquare", 20.0));
            shape.Add(new Circle("SecondCircle", 5.0));
            shape.Add(new Square("SecondSquare", 8.0));


            //LINQ
            var areaFilter = shape.Where(s => s.Area() >= 10 && s.Area() <= 100); //filter by area
            using (StreamWriter streamWriter = new StreamWriter("shapes.txt"))
            {
                foreach (var s in areaFilter)
                {
                    streamWriter.WriteLine($"{s.Name}: Area = {s.Area():F2}");
                }                        

            }
            //var nameFilter = shape.Where(s => s.Name.Contains("a"));// //filter by name containing "a"
            // Use Regex to find shapes that start with 'S' or 'C'
            var regexFilter = shape.Where(s => Regex.IsMatch(s.Name, @"^First"));
            using (StreamWriter streamWriter2 = new StreamWriter("names_with_First.txt")) //instead "a" we use regex to filter names that start with "First"//
            {
                foreach (var s in regexFilter) //regexFilter instead of nameFilter which was used with Contains ("a")//
                {
                    //streamWriter2.WriteLine($"{s.Name}: Name = {s.Name}");//
                    streamWriter2.WriteLine($"{s.Name}: Name starts with First");
                    Console.WriteLine($"[Regex Match]: {s.Name} starts with First"); // Print to console as well
                }
            }
            shape.RemoveAll(s => s.Perimeter() < 5); //remove shapes with perimeter less than 5

            foreach (var s in shape)
            {
                Console.WriteLine($"{s.Name}: Perimeter = {s.Perimeter():F2}");
            }
            //RETURN
            return shape;

        }

        static void ExecuteTask10_2()
        {
            // Read all lines from the file "data.txt"
            string[] lines = File.ReadAllLines("data.txt");

            Console.WriteLine("--- Lines and their lengths ---");
            // For each line, print the line and its length
            Console.WriteLine();
            string maxLine = lines[0];
            string minLine = lines[0];

            foreach (string line in lines)
            {
                Console.WriteLine($"Line: \"{line}\", Length: {line.Length}");
                if (line.Length > maxLine.Length)
                {
                    maxLine = line;
                }
                if (line.Length < minLine.Length)
                {
                    minLine = line;
                }
            }
            // After processing all lines, print the longest and shortest lines
            Console.WriteLine($"\nLongest line: {maxLine}");
            Console.WriteLine($"Shortest line: {minLine}");

            // Use LINQ to filter lines that contain the word "var" (case-insensitive)
            var varLines = lines.Where(l => l.Contains("var", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\n--- Lines containing 'var' ---");
            foreach (var line in varLines)
            {
                Console.WriteLine(line);
            }
        }

        static void ExecuteTask10_4()
        {
            // Create a Student object with a name and a list of marks
            Student student = new Student
            {
                Name = "Viktoriia",
                Marks = new List<int> { 95, 88, 92 }
            };

            // Create JsonSerializerOptions to format the JSON output (optional)
            var options = new JsonSerializerOptions { WriteIndented = true };

            // Serialize the Student object to a JSON string
            string jsonString = JsonSerializer.Serialize(student, options);

            File.WriteAllText("student.json", jsonString);
            Console.WriteLine("Student has been serialized to student.json");

            // Read the JSON string from the file and deserialize it back to a Student object
            string jsonFromFile = File.ReadAllText("student.json");

            Student restoredStudent = JsonSerializer.Deserialize<Student>(jsonFromFile);
            Console.WriteLine($"Restored student: {restoredStudent.Name}, Marks count: {restoredStudent.Marks.Count}");
        }
    } // End of Program class
    abstract class Shape
    {
        public string Name { get; set; }
        public Shape(string name) => Name = name;
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name) => Radius = radius;
        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;
    }

    class Square : Shape
    {
        public double Side { get; set; }
        public Square(string name, double side) : base(name) => Side = side;
        public override double Area() => Side * Side;
        public override double Perimeter() => 4 * Side;
    } // End of Shape, Circle, and Square classes

    // Task 10_3, 10_4: Student class with event
    internal class Student
    {
        public string Name { get; set; } = string.Empty; // Name of the student
        public List<int> Marks { get; set; } // List of marks for the student

        public Student()
        {
            Marks = new List<int>();
        }

        public event MyDel? MarkChange;

        public void AddMark(int mark) // Method to add a mark and trigger the MarkChange event
        {
            Marks.Add(mark); // Add the mark to the list of marks
            MarkChange?.Invoke(mark);
        }
    }

    internal class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"Parent notified: New mark added - {mark}");
        }
    }

    internal class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 90)
            {
                Console.WriteLine("Accountancy: Fellowship awarded!");
            }
            else
            {
                Console.WriteLine("Accountancy: No fellowship awarded.");
            }
        }
    }
}// Namespace ConsoleAppVRHW10

/* * BONUS: IEnumerable vs IQueryable
 * - IEnumerable: Це мій List<Shape>. Програма бере всі фігури з пам'яті та по черзі перевіряє їх через Regex.
 * - IQueryable: Це для баз даних. Він дозволяє не тягнути купу даних у код, а каже самій базі: "відфільтруй і дай мені тільки фігури на F".
 */