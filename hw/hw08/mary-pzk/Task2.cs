namespace Task2
{
    class Program
    {
        static double Division(double a, double b)
        {
            if (b == 0) {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first double: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Enter second double: ");
                    double b = double.Parse(Console.ReadLine());

                    double result = Division(a, b);
                    Console.WriteLine($"Result: {result:F2}.");

                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}
