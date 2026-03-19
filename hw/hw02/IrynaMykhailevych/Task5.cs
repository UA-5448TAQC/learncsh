using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace hw02_IrynaMykhailevych
{
    internal class Task5

    {
        static void Main()
        {
            int squareSide = ReadInt("Enter side of square:");

            int area = squareSide * squareSide;
            int perimeter = 4 * squareSide;

            Console.WriteLine("Square area is: " + area);
            Console.WriteLine("Square perimeter is: " + perimeter);
        }

        static int ReadInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result) || result <= 0)
            {
                Console.WriteLine("Please enter a valid integer:");
                input = Console.ReadLine();
            }

            return result;

        }

    }

}
