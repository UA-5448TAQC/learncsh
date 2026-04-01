namespace HW_3
{
    internal class Task_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter double:");
            double number;
            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            double fraction = number - (int)number;
            fraction = Math.Abs(fraction);

            int first = (int)Math.Round(fraction * 10);
            int second = (int)Math.Round(fraction * 100) % 10;

            int sum = first + second;

            Console.WriteLine($"Your numbers are: {first} and {second}.");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}