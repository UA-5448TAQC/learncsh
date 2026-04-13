namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {

                sum += number % 10;
                number /= 10;

            }

            Console.WriteLine($"The sum of digits of the entered integer number: {sum}", sum);
        }
    }
}