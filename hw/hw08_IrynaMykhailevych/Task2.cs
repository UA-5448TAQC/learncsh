using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw08_IrynaMykhailevych
{
    internal class Task2
    {
        static void Run()
        {
            try
            {
                double a = 20.55;
                double b = 0;

                Division(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Error: Division by zero is not allowed.");
            }

            double result = a / b;
            Console.WriteLine($"Result of {a} / {b} = {result}");
        }
    }
}
