namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            bool onlyOdd = true;
            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    onlyOdd = false;
                    break;
                }

                number /= 10;
            }

            Console.WriteLine(onlyOdd);
        }
    }
}