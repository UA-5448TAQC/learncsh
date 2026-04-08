using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw08_IrynaMykhailevych
{
    internal class Task3
    {
        static void Run()
        {
            int start = 1;
            int end = 100;

            for (int i = 1; i <= 10; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Enter number {i}:");
                        int number = ReadNumber(start, end);

                        start = number;
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            int number;

            if (!int.TryParse(input, out number))
            {
                throw new FormatException("Error: Invalid input format.");
            }
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException("Error: Input is out of range.");
            }
            return number;
        }
    }
}
