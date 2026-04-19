namespace Task1
{
    internal class Program
    {
        public static int Div(int a, int b)
        {
           return a / b;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                int result = Div(a, b);
                Console.WriteLine($"Result: {result}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
    }
}
