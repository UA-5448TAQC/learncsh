namespace HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers");
            int[] number = new int[10];

            for (int i = 0; i < 10; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                if (number[i] > 0)
                {
                    count++;
                }
            }

            if (count == 5)
            {
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    sum = sum + number[i];
                }

                Console.WriteLine($"The sum of first 5 numbers is {sum}.");
            }
            else
            {
                int product = 1;

                for (int i = 5; i < 10; i++)
                {
                    product = product * number[i];
                }

                Console.WriteLine($"The product of last 5 numbers is {product}.");
            }
        }
    }
}
