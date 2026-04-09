using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionFilesCollectionsTasks
{
    public class DivisionByZeroCustomException : Exception
    {
        public DivisionByZeroCustomException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-> Task 1: Division with Exception Handling ");
            Task1_DivisionWithExceptionHandling();

            Console.WriteLine("\n-> Task 2: Throwing Custom Exception ");
            Task2_CustomExceptionDivision();

            Console.WriteLine("\n-> Task 3: Validate Input Range ");
            Task3_ReadTenNumbers();

            Console.WriteLine("\n-> Task 4.1: File Copy with StreamReader / StreamWriter ");
            Task4_CopyWithStreams("data.txt", "rez.txt");

            Console.WriteLine("\n-> Task 4.2: File Copy with File.ReadAllText / WriteAllText ");
            Task4_CopyWithFileClass("data.txt", "rez_all.txt");

            Console.WriteLine("\n-> Task 5: Directory Information ");
            Task5_WriteDirectoryInfo(@"D:\", "DirectoryC.txt");

            Console.WriteLine("\n-> Task 6: Read Only .txt Files ");
            Task6_ReadOnlyTxtFiles(@"C:\Files");

            Console.WriteLine("\n-> Task 7: PhoneBook with Dictionary ");
            Task7_PhoneBook("phones.txt");

            Console.WriteLine("\nProgram finished.");
        }


        static void Task1_DivisionWithExceptionHandling()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first integer: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Enter second integer: ");
                    int b = int.Parse(Console.ReadLine());

                    int result = Div(a, b);
                    Console.WriteLine($"Result: {result}");

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input format. Please enter integers only.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }

            Console.WriteLine("Task 1 completed.");
        }

        static int Div(int a, int b)
        {
            return a / b;
        }


        static void Task2_CustomExceptionDivision()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first double: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Enter second double: ");
                    double b = double.Parse(Console.ReadLine());

                    double result = DivideDouble(a, b);
                    Console.WriteLine($"Result: {result}");

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input format. Please enter valid double numbers.");
                }
                catch (DivisionByZeroCustomException ex)
                {
                    Console.WriteLine("Custom exception: " + ex.Message);
                }
            }

            Console.WriteLine("Task 2 completed.");
        }

        static double DivideDouble(double a, double b)
        {
            if (b == 0)
            {
                throw new DivisionByZeroCustomException("You cannot divide by zero.");
            }

            return a / b;
        }


        static void Task3_ReadTenNumbers()
        {
            int[] numbers = new int[10];
            int previous = 1;

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        int numbersLeft = 10 - i - 1;
                        int start = previous + 1;
                        int end = 99 - numbersLeft;

                        Console.Write($"Enter number {i + 1} (in range [{start}...{end}]): ");

                        numbers[i] = ReadNumber(start, end);
                        previous = numbers[i];
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Format error: " + ex.Message);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Range error: " + ex.Message);
                    }
                }
            }

            Console.WriteLine("You entered valid numbers:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Task 3 completed.");
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException($"Number must be in range [{start}...{end}].");
            }

            return number;
        }


        static void Task4_CopyWithStreams(string inputFile, string outputFile)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(inputFile);
                writer = new StreamWriter(outputFile);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }

                Console.WriteLine("File copied successfully using StreamReader and StreamWriter.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: Input file not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (writer != null)
                    writer.Close();

                Console.WriteLine("Task 4.1 completed.");
            }
        }


        static void Task4_CopyWithFileClass(string inputFile, string outputFile)
        {
            try
            {
                string content = File.ReadAllText(inputFile);
                File.WriteAllText(outputFile, content);

                Console.WriteLine("File copied successfully using File.ReadAllText and File.WriteAllText.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: Input file not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Task 4.2 completed.");
            }
        }


        static void Task5_WriteDirectoryInfo(string diskPath, string outputFile)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    WriteDirectoryInfoRecursive(diskPath, writer);
                }

                Console.WriteLine("Directory information saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while writing directory information: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Task 5 completed.");
            }
        }

        static void WriteDirectoryInfoRecursive(string currentPath, StreamWriter writer)
        {
            try
            {
                string[] directories = Directory.GetDirectories(currentPath);
                foreach (string dir in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);
                    writer.WriteLine($"Name: {dirInfo.Name} | Type: Directory");

                    WriteDirectoryInfoRecursive(dir, writer);
                }

                string[] files = Directory.GetFiles(currentPath);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    writer.WriteLine($"Name: {fileInfo.Name} | Type: File | Size: {fileInfo.Length} bytes");
                }
            }
            catch (UnauthorizedAccessException)
            {
                writer.WriteLine($"Access denied: {currentPath}");
            }
            catch (Exception ex)
            {
                writer.WriteLine($"Error in {currentPath}: {ex.Message}");
            }
        }


        static void Task6_ReadOnlyTxtFiles(string diskPath)
        {
            try
            {
                string[] txtFiles = Directory.GetFiles(diskPath, "*.txt", SearchOption.AllDirectories);

                foreach (string file in txtFiles)
                {
                    try
                    {
                        Console.WriteLine($"\n--- File: {file} ---");
                        string content = File.ReadAllText(file);
                        Console.WriteLine(content);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Cannot read file {file}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while searching txt files: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Task 6 completed.");
            }
        }


        static void Task7_PhoneBook(string inputFile)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                if (!File.Exists(inputFile))
                {
                    Console.WriteLine("phones.txt not found.");
                    return;
                }

                string[] lines = File.ReadAllLines(inputFile);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length >= 2)
                    {
                        string name = parts[0];
                        string phone = parts[1];

                        if (!phoneBook.ContainsKey(name))
                        {
                            phoneBook.Add(name, phone);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter("Phones.txt"))
                {
                    foreach (var pair in phoneBook)
                    {
                        writer.WriteLine(pair.Value);
                    }
                }

                while (true)
                {
                    Console.Write("Enter name to search: ");
                    string searchName = Console.ReadLine();

                    if (phoneBook.ContainsKey(searchName))
                    {
                        Console.WriteLine($"Phone number: {phoneBook[searchName]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Name not found. Try again.");
                    }
                }

                using (StreamWriter writer = new StreamWriter("New.txt"))
                {
                    foreach (var pair in phoneBook)
                    {
                        string updatedPhone = pair.Value;

                        if (updatedPhone.StartsWith("80") && updatedPhone.Length == 11)
                        {
                            updatedPhone = "+3" + updatedPhone;
                        }

                        writer.WriteLine($"{pair.Key} {updatedPhone}");
                    }
                }

                Console.WriteLine("PhoneBook processed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in PhoneBook task: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Task 7 completed.");
            }
        }
    }
}
