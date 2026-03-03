using System;
using System.Globalization;

namespace ConsoleAppTasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task1_FloatNumbersInRange();
            PrintSeparator();

            Task2_MaxMinOfIntegers();
            PrintSeparator();

            Task3_HttpErrorEnum();
            PrintSeparator();

            Task4_StructDog();
            PrintSeparator();

            Task5_ValidDateCheck();
            PrintSeparator();

            Task6_SumOfFirstTwoDigitsAfterDecimalPoint();
            PrintSeparator();

            Task7_GreetingByHour();
            PrintSeparator();

            Task8_TestCaseStatusEnum();
            PrintSeparator();

            Task9_StructRgb();
            PrintSeparator();

            Console.WriteLine("All tasks completed. Press any key to exit...");
            Console.ReadKey();
        }

        // 1️ Float Numbers in Range
        private static void Task1_FloatNumbersInRange()
        {
            Console.WriteLine("Task 1 — Float Numbers in Range [-5; 5]");

            float a = ReadFloat("Enter first float number:");
            float b = ReadFloat("Enter second float number:");
            float c = ReadFloat("Enter third float number:");

            bool inRange = IsInRange(a, -5f, 5f) && IsInRange(b, -5f, 5f) && IsInRange(c, -5f, 5f);

            Console.WriteLine($"All numbers are in range [-5; 5]: {inRange}");
        }

        // 2️ Max and Min of Integers
        private static void Task2_MaxMinOfIntegers()
        {
            Console.WriteLine("Task 2 — Max and Min of Integers");

            int x = ReadInt("Enter first integer:");
            int y = ReadInt("Enter second integer:");
            int z = ReadInt("Enter third integer:");

            int max = Math.Max(x, Math.Max(y, z));
            int min = Math.Min(x, Math.Min(y, z));

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }

        // 3️ HTTP Error Enum
        private static void Task3_HttpErrorEnum()
        {
            Console.WriteLine("Task 3 — HTTP Error Enum");

            int code = ReadInt("Enter HTTP error code (400-404):");

            if (Enum.IsDefined(typeof(HTTPError), code))
            {
                HTTPError error = (HTTPError)code;
                Console.WriteLine($"Error name: {error}");
            }
            else
            {
                Console.WriteLine("Unknown/unsupported HTTP error code for this enum.");
            }
        }

        private enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }

        // 4️ Struct Dog
        private static void Task4_StructDog()
        {
            Console.WriteLine("Task 4 — Struct Dog");

            Dog myDog = new Dog();

            Console.WriteLine("Enter dog name:");
            myDog.Name = ReadNonEmptyString();

            Console.WriteLine("Enter dog mark (breed):");
            myDog.Mark = ReadNonEmptyString();

            myDog.Age = ReadIntMin("Enter dog age (>= 0):", 0);

            Console.WriteLine("Dog info:");
            Console.WriteLine(myDog.ToString());
        }

        private struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            public override string ToString()
            {
                return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
            }
        }

        // 5️ Valid Date Check (day + month)
        private static void Task5_ValidDateCheck()
        {
            Console.WriteLine("Task 5 — Valid Date Check (day & month)");

            int day = ReadInt("Enter day (integer):");
            int month = ReadInt("Enter month (integer):");

            bool isValid = IsValidDayMonth(day, month);

            Console.WriteLine($"Valid day/month: {isValid}");
        }

        private static bool IsValidDayMonth(int day, int month)
        {
            if (month < 1 || month > 12)
            {
                return false;
            }

            int daysInMonth = month switch
            {
                1 => 31,
                2 => 28, 
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => 0
            };

            return day >= 1 && day <= daysInMonth;
        }

        // 6️ Sum of First Two Digits After Decimal Point
        private static void Task6_SumOfFirstTwoDigitsAfterDecimalPoint()
        {
            Console.WriteLine("Task 6 — Sum of First Two Digits After Decimal Point");

            decimal value = ReadDecimal("Enter a decimal number (e.g., 3.456):");
            decimal abs = Math.Abs(value);

            int firstDigit = (int)(abs * 10) % 10;
            int secondDigit = (int)(abs * 100) % 10;
            int sum = firstDigit + secondDigit;

            Console.WriteLine($"{firstDigit} + {secondDigit} = {sum}");
        }

        // 7️ Greeting by Hour
        private static void Task7_GreetingByHour()
        {
            Console.WriteLine("Task 7 — Greeting by Hour");

            int hour = ReadIntRange("Enter hour (0-23):", 0, 23);

            string greeting = hour switch
            {
                >= 6 and <= 11 => "Good morning!",
                >= 12 and <= 17 => "Good afternoon!",
                >= 18 and <= 22 => "Good evening!",
                _ => "Good night!"
            };

            Console.WriteLine(greeting);
        }

        // 8️ Test Case Status Enum
        private static void Task8_TestCaseStatusEnum()
        {
            Console.WriteLine("Task 8 — Test Case Status Enum");

            TestCaseStatus test1Status = TestCaseStatus.Pass;

            Console.WriteLine($"test1Status = {test1Status}");
        }

        private enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }

        // 9️ Struct RGB
        private static void Task9_StructRgb()
        {
            Console.WriteLine("Task 9 — Struct RGB");

            RGB white = new RGB(255, 255, 255);
            RGB black = new RGB(0, 0, 0);

            Console.WriteLine($"White: {white}");
            Console.WriteLine($"Black: {black}");
        }

        private readonly struct RGB
        {
            public byte Red { get; }
            public byte Green { get; }
            public byte Blue { get; }

            public RGB(byte red, byte green, byte blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }

            public override string ToString()
            {
                return $"({Red}, {Green}, {Blue})";
            }
        }

        // Helpers
        private static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 50));
        }

        private static bool IsInRange(float value, float min, float max)
        {
            return value >= min && value <= max;
        }

        private static int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                Console.WriteLine("Invalid integer. Please try again.");
            }
        }

        private static int ReadIntMin(string message, int minValue)
        {
            while (true)
            {
                int value = ReadInt(message);

                if (value >= minValue)
                {
                    return value;
                }

                Console.WriteLine($"Value must be >= {minValue}. Please try again.");
            }
        }

        private static int ReadIntRange(string message, int minValue, int maxValue)
        {
            while (true)
            {
                int value = ReadInt(message);

                if (value >= minValue && value <= maxValue)
                {
                    return value;
                }

                Console.WriteLine($"Value must be in range [{minValue}; {maxValue}]. Please try again.");
            }
        }

        private static float ReadFloat(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();
            
                if (float.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out float currentCultureValue))
                {
                    return currentCultureValue;
                }

                if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float invariantValue))
                {
                    return invariantValue;
                }

                Console.WriteLine("Invalid float number. Please try again (e.g., 1.23).");
            }
        }

        private static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();

                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal currentCultureValue))
                {
                    return currentCultureValue;
                }

                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal invariantValue))
                {
                    return invariantValue;
                }

                Console.WriteLine("Invalid number. Please try again (e.g., 3.456).");
            }
        }

        private static string ReadNonEmptyString()
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Input cannot be empty. Please try again:");
            }
        }
    }
}