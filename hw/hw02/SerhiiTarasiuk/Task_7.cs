namespace ConsoleApp1
{
    internal class Task_7
    {
        static void Main(string[] args)
        {

            static double ReadRadius()
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double result) && result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are kidding... Only positive numbers are allowed. Try again.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Enter the radius of the circle:");

            double radius = ReadRadius();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\n\nLets perform some calculations:\n" +
                $"Length of the circle is " + $"{2 * Math.PI * radius}.\n" +    
                $"Area of the circle is {Math.PI * radius * radius}.\n" +
                $"Volume of the sphere is {4/3 * Math.PI * Math.Pow(radius, 3)}.");

        }
    }
}
