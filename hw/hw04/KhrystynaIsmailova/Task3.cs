namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[10];

            // 1. Вводимо 10 чисел
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // 2. Перевіряємо перші 5
            bool allPositive = true;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    allPositive = false;
                    break;
                }
            }

            if (allPositive)
            {
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                int product = 1;

                for (int i = 5; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }

                Console.WriteLine(product);
            }

        }
    }
}