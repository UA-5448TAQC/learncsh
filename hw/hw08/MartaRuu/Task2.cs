namespace ConsoleApp3
{
    public class DivisionByZeroCustomException : Exception
    {
        public DivisionByZeroCustomException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first double number: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter second double number: ");
                double b = double.Parse(Console.ReadLine());

                double result = Divide(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivisionByZeroCustomException exc)
            {
                Console.WriteLine($"Custom exception caught: {exc.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Unexpected error: {exc.Message}");
            }
            finally
            {
                Console.WriteLine("Task 2 finished.");
            }
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivisionByZeroCustomException("Division by zero is forbidden.");
            }

            return a / b;
        }
    }
}