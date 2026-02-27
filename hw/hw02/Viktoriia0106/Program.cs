namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  TASK 1 — Arithmetic Operations
            int a;
            int b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            //  TASK 2 — Simple Question
            Console.WriteLine("How are you?");
            string answer;
            answer = Console.ReadLine();
            Console.WriteLine("You are " + answer);

            //  TASK 3 — Working with char
            char first;
            char second;
            char third;
            Console.WriteLine("Enter first char:");
            first = Console.ReadLine()[0];
            Console.WriteLine("Enter second char:");
            second = Console.ReadLine()[0];
            Console.WriteLine("Enter third char:");
            third = Console.ReadLine()[0];
            Console.WriteLine("You entered: " + first + ", " + second + ", " + third);

            //  TASK 4 — Working with integer numbers
            int num1;
            int num2;
            Console.WriteLine("Enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            bool result = num1 > 0 && num2 > 0;
            Console.WriteLine("Result is " + result);

            //  TASK 5 — Square Calculations
            int side;
            int area;
            int perimeter;
            Console.WriteLine("Enter the side of the square:");
            side = Convert.ToInt32(Console.ReadLine());
            area = side * side; 
            Console.WriteLine("Area of the square: " + area);
            perimeter = 4 * side;
            Console.WriteLine("Perimeter of the square: " + perimeter);

            //  TASK 6 — Name and Age
            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();
            int age;
            Console.WriteLine("How old are you " + name + "?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");

            //  TASK 7 — Circle Calculations
            double r;
            Console.WriteLine("Enter the radius of a circle:");
            r = Convert.ToDouble(Console.ReadLine());
            double length;
            length = 2 * Math.PI * r;
            Console.WriteLine("Length of the circle is " + length);
            double circleArea;
            circleArea = Math.PI * r * r;
            Console.WriteLine("Area of the circle is " + circleArea);
            double volume;
            volume = (4.0 / 3.0) * Math.PI * r * r * r;
            Console.WriteLine("Volume of the circle is " + volume);
        }
    }
}
