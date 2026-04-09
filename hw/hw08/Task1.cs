namespace Task1
{
    internal class Program
    {
        static int Div(int a, int b)
        {
            return a / b;
        }k
        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                int result = Div(a, b);

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ne dilytsia na nul");
            }
            catch (FormatException)
            {
                Console.WriteLine("Proshu vvesty tilky tsyfry");
            }
        }
    }
}
