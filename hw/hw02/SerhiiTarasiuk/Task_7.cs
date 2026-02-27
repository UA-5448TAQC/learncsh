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

            double length = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Volume: {volume}");
           
            Console.ResetColor();
        }
    }
}
