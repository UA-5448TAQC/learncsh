using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppVRHW08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuteTask8_1();
            //ExecuteTask8_2();
            //ExecuteTask8_3();
            //ExecuteTask8_4_1();
            //ExecuteTask8_4_2();
            //ExecuteTask8_5();
            //ExecuteTask8_6();
            //ExecuteTask8_7();
        }

        // Task 8.1 //
        static int Div(int a, int b)
        {
            return a / b;
        }
                
        static void ExecuteTask8_1()
        {           
            try
            {
                Console.Write("Enter first integer: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int y = int.Parse(Console.ReadLine());

                int result = Div(x, y);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }

        // Task 8.2 //
        static double DivDouble(double a, double b)
        {
            // Check for division by zero and throw an exception if it occurs //
            if (b == 0)
            {
                throw new DivideByZeroException("Explicit division of double by zero!");
            }
            return a / b;
        }

        static void ExecuteTask8_2()
        {           
            try
            {
                Console.Write("Enter first double: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter second double: ");
                double y = double.Parse(Console.ReadLine());

                double result = DivDouble(x, y);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid format for double.");
            }
            catch (DivideByZeroException error)
            {
                // Here we catch the specific exception for division by zero and print the custom message from the exception //
                Console.WriteLine($"Caught exception: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine("An unexpected error occurred: " + error.Message);
            } 
        }

        // Task 8.3 //
        static int ReadNumber(int start, int end)
        {
            Console.Write($"Enter a number between {start} and {end}: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new Exception($"Number must be between {start} and {end}."); // Here we throw a general exception with a custom message if the number is out of range //
            }
            return number;
        }

        static void ExecuteTask8_3()
        {
            int currentStart = 1;
            int currentEnd = 100;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = ReadNumber(currentStart, currentEnd);
                    Console.WriteLine($"You entered: {number}");
                    // Update the range for the next input
                    currentStart = number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input format. Please enter an integer.");
                    i--;
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error: {error.Message}");
                    i--;
                }
            } // After 10 iterations, the program will end.
        } // ExecuteTask8_3 //

        // Task 8.4_1 and 8.4_2 //
        static void ExecuteTask8_4_1()
        {
            try
            {
                // Constructing the "using block" to ensure proper disposal of resources after file operations, and to handle any potential exceptions that may arise during file reading/writing. //
                using (StreamReader reader = new StreamReader("data.txt"))
                using (StreamWriter writer = new StreamWriter("rez.txt"))
                {
                    string line;
                    // Read the file line by line until the end of the file is reached (when ReadLine returns null) //
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Write each line to the console and also write it to the output file "rez.txt" //
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Done! Line-by-line copy finished.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in 4.1: " + ex.Message);
            }
        }

        static void ExecuteTask8_4_2()
        {
            try
            {
                string filePath = "data.txt";
                string content = File.ReadAllText(filePath);
                File.WriteAllText("rez.txt", content);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The specified file was not found.");
            }
            catch (Exception error)
            {
                Console.WriteLine("An unexpected error occurred: " + error.Message);
            }
          
        } // ExecuteTask8_4_2 //

        // Task 8.5 //
        static void ExecuteTask8_5()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\vroma3\Documents\GitHub\learncsh\hw\hw08\Viktoriia0106\ConsoleAppVRHW08"); //Alternative:= DirectoryInfo dir = new DirectoryInfo("."); //                                                                                                                                           // DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

                using (StreamWriter writer = new StreamWriter("DirectoryC.txt"))

                {
                    DirectoryInfo[] subDirs = dir.GetDirectories();
                    FileInfo[] files = dir.GetFiles();

                    writer.WriteLine("DIRECTORIES:");
                    foreach (DirectoryInfo subDir in subDirs)
                    {
                        writer.WriteLine($"{subDir.Name} | Directory");
                    }

                    writer.WriteLine("\nFILES:");
                    foreach (FileInfo file in files)
                    {
                        writer.WriteLine($"{file.Name} | File | {file.Length} bytes"); // Info about file size + type + name//
                    }
                   
                }
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: The specified directory was not found.");
            }
            catch (Exception error)
            {
                Console.WriteLine("An unexpected error occurred: " + error.Message);
            }
        } // ExecuteTask8_5 //


        // Task 8.6 //
        static void ExecuteTask8_6()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\vroma3\Documents\GitHub\learncsh\hw\hw08\Viktoriia0106\ConsoleAppVRHW08");
                FileInfo[] files = dir.GetFiles("*.txt");

                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"{file.Name} | {file.Length} bytes");
                    string content = File.ReadAllText(file.FullName);
                    Console.WriteLine($"--- CONTENT ---\n{content}\n----------------"); // Info about file size + name + content//
                }

            } // catch specific exception for directory not found, and a general catch for any other unexpected exceptions
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: The specified directory was not found.");
            }
            catch (Exception error)
            {
                Console.WriteLine("An unexpected error occurred: " + error.Message);
            }

        }

        // Task 8.7 //
        static void ExecuteTask8_7()
            {
            try
            {
                Dictionary<string, string> phoneBook = new Dictionary<string, string>();
                phoneBook.Add("Zoriana", "+380501111111");
                phoneBook.Add("Uliana", "+380502222222");
                phoneBook.Add("Davyd", "+380503333333");
                phoneBook.Add("Serhiy", "+380504444444");

                foreach (KeyValuePair<string, string> entry in phoneBook)
                {
                    Console.WriteLine($"Name: {entry.Key} | Phone: {entry.Value}");
                }

                Console.Write("Enter name to search: ");
                string searchName = Console.ReadLine();

                if (phoneBook.ContainsKey(searchName))
                    Console.WriteLine($"Phone: {phoneBook[searchName]}");
                else
                    Console.WriteLine($"Error: Sorry, Name '{searchName}' not found in the phone book.");
            }
            
            catch (ArgumentException)
            {
                Console.WriteLine("Error: Duplicate key in the phone book.");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Error: Name not found in the phone book.");
            }
            
            catch (Exception error)
            {
                Console.WriteLine("An unexpected error occurred: " + error.Message);
            }
        } // ExecuteTask8_7 //
    } // class Program //
} // namespace ConsoleAppVRHW08 //
