
namespace ConsoleAppHW04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Read a string str.
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int count = 0;

            foreach (char c in str)
            {
                if (c == 'a' || c == 'o' || c == 'i' || c == 'e' || c == 'A' || c == 'O' || c == 'I' || c == 'E')
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of characters: {count}");

            //Task 2: Ask the user to enter a month number(1–12).Output the number of days in this month.
            Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month");
            }
            else if (month == 2)
            {
                Console.WriteLine($"Month {month} has 28 days.");
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine($"Month {month} has 30 days");
            }
            else
            {
                Console.WriteLine($"Month {month} has 31 days");
            }


            //Task 3: Enter 10 integer numbers.
            Console.WriteLine("Enter 10 integer numbers: positive or negative");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");

                numbers[i] = int.Parse(Console.ReadLine());
            }
            bool allFirstFivePositive = true;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    allFirstFivePositive = false;
                    break;
                }
            }
            int result;
            if (allFirstFivePositive)
            {
                result = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
                Console.WriteLine($"Sum of first 5 numbers: {result}");
            }
            else
            {
                result = numbers[5] * numbers[6] * numbers[7] * numbers[8] * numbers[9];
                Console.WriteLine($"Product of last 5 numbers: {result}");
            }


            //Task 4: Enter two integers a and b.
            Console.Write("Enter first integer a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer b: ");
            int b = int.Parse(Console.ReadLine());
            int divisibleCount = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleCount++;
                }
            }
            Console.WriteLine($"Result: {divisibleCount}");


            //Task 5: Enter a string text.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            int textCount = 1;
            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }


            //Task 6: Enter a string text.
            Console.WriteLine("Enter drink: coffee/tea/juice/water");
            string drink = Console.ReadLine();
            switch (drink.ToLower())
            {
                case "coffee":
                    Console.WriteLine("Drink: coffee, Price: 80"); break;
                case "tea":
                    Console.WriteLine("Drink: tea, Price: 40"); break;
                case "juice":
                    Console.WriteLine("Drink: juice, Price: 100"); break;
                case "water":
                    Console.WriteLine("Drink: water, Price: 30"); break;
                default:
                    Console.WriteLine("Unknown drink");
                    break;
            }


           // Task 7: Enter a string text.
            Console.WriteLine("Enter numbers (include negative to stop):");
            double totalSum = 0;
            int countPositiveNumbers = 0;
            int currentNumber = int.Parse(Console.ReadLine());

            while (currentNumber >= 0)
            {
                totalSum += currentNumber;
                countPositiveNumbers++;
                currentNumber = int.Parse(Console.ReadLine());
            }
            if (countPositiveNumbers > 0)
            {
                double average = totalSum / countPositiveNumbers;
                Console.WriteLine($"Average of positive numbers: {average}");
            }
            else
            {
                Console.WriteLine("No positive numbers entered.");
            }


            //Task 8: Check if the entered year is a leap year.Enter a string text.
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }


            //Task 9: Find the sum of digits of the entered integer number.
            Console.WriteLine("Enter an integer number (two-digit or three-digit or four-digit): ");
            int anyDigitNumber = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            while (anyDigitNumber > 0)
            {
                sumOfDigits += anyDigitNumber % 10; anyDigitNumber /= 10;
            }
            Console.WriteLine($"Sum of digits: {sumOfDigits}");


            //Task 10: Enter a string text.
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool allOdd = true;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    Console.WriteLine($"Digit {digit} is odd");
                }
                else
                {
                    Console.WriteLine($"Digit {digit} is even");
                    allOdd = false;
                }
                number /= 10;
            }

        }


    }
}

            
            
            

            