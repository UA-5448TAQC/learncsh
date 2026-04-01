namespace hw08_IrynaMykhailevych
{
    internal class Task1
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter b: ");
                    int b = int.Parse(Console.ReadLine());

                    Div(a, b);

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input format.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }

        }
        static void Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Result of {a} / {b} = {result}");
        }
    }
}
