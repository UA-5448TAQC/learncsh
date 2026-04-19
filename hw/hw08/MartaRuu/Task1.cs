namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        { 
  try
            {
                Console.Write("Enter first integer: ");
                int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
                int b = int.Parse(Console.ReadLine());

        int result = Div(a, b);
        Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter integers only.");
            }
            catch (DivideByZeroException)
            {
    Console.WriteLine("Error: Division by zero is not allowed.");
}
            catch (Exception exc)
            {
    Console.WriteLine($"Unexpected error: {exc.Message}");
}
            finally
            {
    Console.WriteLine("Task 1 finished.");
}
        }
        static int Div(int a, int b)
{
    return a / b;
}
    }
}


