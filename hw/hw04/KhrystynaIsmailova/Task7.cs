namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the numbers: ");
            string input = Console.ReadLine();

            int sum = 0;
            int count = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                    break;

                sum += number;
                count++;
            }

            double average = (double)sum / count;

            Console.WriteLine($"The arithmetic average of all positive numbers: {average}", average);

        }
    }
}