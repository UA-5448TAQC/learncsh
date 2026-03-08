using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04.Helpers
{
    internal class ProgramHelpers
    {
        public void EndOfTask()
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====Task Completed====");
            Console.ResetColor();
        }

        public static void PrintTask(int number, string description)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{number} - Task{number:D2} - Description:");
            Console.ResetColor();
            Console.WriteLine(description);
        }
        
        public static int ReadInt(string input)
        {
            int result;
            while (true)
            {
                Console.WriteLine(input);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.ResetColor();
                }
            }
        }
    }
}