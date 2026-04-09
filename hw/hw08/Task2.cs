namespace Task2
{
    internal class Program
    {
        static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ne moz na nul!");
            }

            return a / b;
        }
        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double result = Div(a, b);

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
