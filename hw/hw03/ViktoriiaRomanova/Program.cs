using System;
namespace ConsoleAppHW03
{
    enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404
    }

    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return $"Name: {name}, Mark: {mark}, Age: {age}";
            // Alternative: return "Name: " + name + ", Mark: " + mark + ", Age: " + age;
        }
    }

    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }

    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Task 1: Check if three numbers are in the range [-5, 5]
            Console.Write("Enter first number: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            float number2 = float.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            float number3 = float.Parse(Console.ReadLine());

            if (number1 >= -5 && number1 <= 5 &&
                number2 >= -5 && number2 <= 5 &&
                number3 >= -5 && number3 <= 5)
            {
                Console.WriteLine("All numbers are in the range [-5, 5] - OK");
            }
            else
            {
                Console.WriteLine("Some numbers are out of the range [-5, 5] - ERROR");
            }

            //// Task 2: Max and Min of three integers
            Console.WriteLine("Enter first integer: ");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer: ");
            int int3 = int.Parse(Console.ReadLine());
            int max = int1;
            int min = int1;
            if (int2 > max)
            {
                max = int2;
            }

            if (int3 > max)
            {
                max = int3;
            }
            if (int2 < min)
            {
                min = int2;
            }

            if (int3 < min)
            {
                min = int3;
            }
            Console.WriteLine($"Max: {max}"); // Alternative:Console.WriteLine("Max: " + max);
            Console.WriteLine($"Min: {min}"); // Alternative: Console.WriteLine("Min: " + min);

            //// Task 3: HTTP Error Enum
            Console.Write("Enter HTTP Error code integer: ");
            string inputText = Console.ReadLine();

            int errorCode;
            bool isNumber = int.TryParse(inputText, out errorCode);

            if (isNumber)
            {
                Console.WriteLine((HTTPError)errorCode);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer (400-404).");
            }

            // Task 4: Dog Struct
            Dog myDog = new Dog();
            Console.Write("Enter dog's name: ");
            myDog.name = Console.ReadLine();
            Console.Write("Enter dog's mark: ");
            myDog.mark = Console.ReadLine();
            Console.Write("Enter dog's age: ");
            string inputAge = Console.ReadLine();
            int age;
            bool isAgeValid = int.TryParse(inputAge, out age);
            if (isAgeValid)
            {
                myDog.age = age;
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer for age.");
            }

            Console.WriteLine(myDog);


            // Task 5: Valid Date Check (day, month)
            Console.WriteLine("Enter day (1-31): ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                Console.WriteLine("Invalid date");
            }
            else if (month == 2 && day > 28)
            {
                Console.WriteLine("Invalid date");
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
            {
                Console.WriteLine("Invalid date");
            }
            else
            {
                Console.WriteLine("Valid date");
            }

            //// Task 6: Sum of First Two Digits After Decimal Point
            Console.Write("Enter a double number: ");
            string inputDouble = Console.ReadLine();

            double number;
            bool isNumberValid = double.TryParse(inputDouble, out number);

            if (isNumberValid)
            {
                double fraction = number - (int)number;

                if (fraction < 0)
                {
                    fraction = -fraction;
                }

                int firstDigit = (int)(fraction * 10);
                int twoDigits = (int)(fraction * 100);
                int secondDigit = twoDigits - firstDigit * 10;

                int sum = firstDigit + secondDigit;

                Console.WriteLine($"{firstDigit} + {secondDigit} = {sum}");
            }
            else
            {
                Console.WriteLine("Invalid data input. Please enter a valid double number.");
            }


            //// Task 7: Greeting by Hour
            Console.Write("Enter hour (0-23): ");
            string hourText = Console.ReadLine();

            int h;
            bool isHourValid = int.TryParse(hourText, out h);

            if (!isHourValid)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            else if (h < 0 || h > 23)
            {
                Console.WriteLine("Invalid hour. Please enter a value from 0 to 23.");
            }
            else if (h >= 6 && h <= 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (h >= 12 && h <= 17)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (h >= 18 && h <= 22)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }

            // Task 8: Test Case Status Enum
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"Test1 status: {test1Status}");

            // Task 9: Struct RGB
            RGB white;
            white.red = 255;
            white.green = 255;
            white.blue = 255;

            RGB black;
            black.red = 0;
            black.green = 0;
            black.blue = 0;

            Console.WriteLine($"White: R={white.red}, G={white.green}, B={white.blue}");
            Console.WriteLine($"Black: R={black.red}, G={black.green}, B={black.blue}");

        }
    }
}
