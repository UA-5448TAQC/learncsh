using System.ComponentModel;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());


            //if (a > min && a < max) {
            //    Console.WriteLine($"a is between min={min} and max={max}");
            //}
            //else
            //{
            //    Console.WriteLine($"a is not between min={min} and max={max}");
            //}
            //Console.WriteLine("Enter your age:");

            //int age = Console.ReadLine() is string input && int.TryParse(input, out int result) ? result : 0;
            //if (age < 6)
            //{
            //    Console.WriteLine("You are a child");
            //}
            //else
            //{
            //    if (age < 18)
            //    {
            //        Console.WriteLine("You are a teenager");
            //    }
            //    else
            //    {
            //        if (age < 65)
            //        {
            //            Console.WriteLine("You are an adult");
            //        }
            //        else
            //        {
            //            Console.WriteLine("You are a senior");
            //        }
            //    }
            //}


            //if (age < 6)
            //{
            //    Console.WriteLine("You are a child");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You are a teenager");
            //}
            //else if (age < 65)
            //{
            //    Console.WriteLine("You are an adult");
            //}
            //else
            //{
            //    Console.WriteLine("You are a senior");
            //}
            //Console.WriteLine("Enter HTTP status code:");

            //int statusCode = Console.ReadLine() is string input && int.TryParse(input, out int result) ? result : 0;

            //switch (statusCode)
            //{
            //    case 200:
            //        Console.WriteLine("OK");
            //        break;
            //    case 400:
            //    case 401:
            //        Console.WriteLine("Unauthorized");
            //        break;
            //    case 403:
            //        Console.WriteLine("Forbidden");
            //        break;
            //    case 404:
            //        Console.WriteLine("Not Found");
            //        break;
            //    //default:
            //    //    Console.WriteLine("Unknown status code");
            //    //    break;
            //}

            //int number = 5;
            //while (number > 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            // 
            //while (number < 10)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number > 0);


            //Console.WriteLine($" number:{number}");

            //int age = 0;

            //while (age != -1)
            //{
            //    if (age < 6)
            //    {
            //        Console.WriteLine("You are a child");
            //    }
            //    else if (age < 18)
            //    {
            //        Console.WriteLine("You are a teenager");
            //    }
            //    else if (age < 65)
            //    {
            //        Console.WriteLine("You are an adult");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are a senior");
            //    }
            //    Console.WriteLine("Enter your age (or -1 to exit):");
            //    age = Console.ReadLine() is string input && int.TryParse(input, out int result) ? result : -1;


            //}

            //int age = 0;


            //int age;

            //do
            //{
            //    Console.WriteLine("Enter your age (or -1 to exit):");
            //    age = Console.ReadLine() is string input && int.TryParse(input, out int result) ? result : -1;
            //    if (age < 6)
            //    {
            //        Console.WriteLine("You are a child");
            //    }
            //    else if (age < 18)
            //    {
            //        Console.WriteLine("You are a teenager");
            //    }
            //    else if (age < 65)
            //    {
            //        Console.WriteLine("You are an adult");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are a senior");
            //    }

            //} while (age != -1);



            //for (int a = 10; a < 20; a++)
            //{
            //    if (a == 15) 
            //            continue;
            //    Console.WriteLine( "value of a: {0}", a);
            //}
            //int i = 0;
            //for (;;)
            //{
            //    Console.WriteLine("value of a: {0}", i);
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    i++;
            //}
            //for (int i = 0, j = 10; i < 100 && j + i < 1000; i++, j *= 5)
            //{
            //    Console.WriteLine($"i: {i}, j: {j}");
            //}

            //int[] arr = { 10, 20, 30, 40, 50 };
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //int[] arr = new int[8];
            //arr[5] = 999;
            //arr[7] = 888;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //string[] arr = { "Hello", "World", "C#", "Programming" };
            //Console.WriteLine(arr.Length);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //    arr[i] = arr[i].ToUpper();
            //    Console.WriteLine($" -> {arr[i]}");
            //}

            //int[,] matrix = {
            //    {1, 2, 3, 4},
            //    {11, 21, 31, 41},
            //    {12, 22, 32, 42},
            //    {13, 23, 33, 43}
            //};
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int diagonalSum = 0;
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    diagonalSum += matrix[i, i];
            //}
            //Console.WriteLine($"diagonalSum={diagonalSum}");
            //Console.WriteLine();

            //int[,] matrix = new int[3, 5];
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value for matrix[{i}, {j}]: ");
            //        matrix[i, j] = Console.ReadLine() is string input && int.TryParse(input, out int result) ? result : 0;
            //    }
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //string[] arr = { "Hello", "World", "C#", "Programming" };

            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //    //item = item.ToUpper();
            //}

            string text = "Hello World";
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"text[{i}]={text[i]}");
            }
            foreach (char c in text)
            {
                int asciiValue = (int)c;
                Console.WriteLine($"{c} - ascii code: {asciiValue}");
            }
            //Console.WriteLine(asciiValue);// Error: The name 'asciiValue' does not exist in the current context
            Console.WriteLine("End of program");

        }
    }
}
