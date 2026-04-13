namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive numbers: ");
            int sum = 0;
            int count = 0;

            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                sum = sum + number;
                count++;

                number = int.Parse(Console.ReadLine());
            }

            if (count == 0)
            {
                Console.WriteLine("No positive numbers were entered.");
            }
            else
            {
                double avr = (double)sum / count;
                Console.WriteLine($"Average number is {avr:F2}.");
            }
        }
    }
}
