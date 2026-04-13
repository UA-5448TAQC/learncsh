
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter positive integers. Enter the first negative number to stop.");

            int sum = 0;
            int count = 0;

            while (true)
            {
                int number = ReadInt("Enter number: ");

                if (number < 0)
                {
                    break;
                }

                sum += number;
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("No positive numbers were entered.");
            }
            else
            {
                double average = (double)sum / count;
                Console.WriteLine($"Arithmetic average: {average:F2}");
            }
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }

                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}