using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw02_IrynaMykhailevych
{
    internal class Task7
    {
        static void Main()
        {
            double r = ReadRadius("Enter radius of the circle:");

            PrintResults(r);
        }

        static double ReadRadius(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            double result;
            while (!double.TryParse(input, out result) || result <= 0)
            {
                Console.WriteLine("Please enter correct radius:");
                input = Console.ReadLine();
            }
            return result;
        }

        static void PrintResults(double r)
        {
            double length = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * r * r * r;

            Console.WriteLine($"Length: {length:F2}, Area: {area:F2}, Volume: {volume:F2}");
        }
    }
}
