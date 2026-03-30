namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            bool isOdd = true;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    isOdd = false;
                    break;
                }

                number = number / 10;
            }

            Console.WriteLine($"Does the number contain only odd digits? {isOdd}");
        }
    }
}