
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Car[] cars = new Car[3];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Enter data for car {i + 1}:");
                cars[i] = new Car();
                cars[i].Input();
                Console.WriteLine();
            }

            Console.WriteLine("Cars before price change:");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Print();
            }

            Console.WriteLine();

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(-10);
            }

            Console.WriteLine("Cars after decreasing price by 10%:");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Print();
            }

            Console.WriteLine();
            Console.WriteLine("Repainting white cars:");

            bool foundWhite = false;

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color.Equals("white", StringComparison.OrdinalIgnoreCase))
                {
                    foundWhite = true;

                    Console.Write($"Car {i + 1} is white. Enter a new color: ");
                    string? newColor = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newColor))
                    {
                        Console.Write("Invalid input. Enter color again: ");
                        newColor = Console.ReadLine();
                    }

                    cars[i].Color = newColor;
                }
            }

            if (!foundWhite)
            {
                Console.WriteLine("No white cars found.");
            }

            Console.WriteLine();
            Console.WriteLine("Cars after repainting:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Comparing cars:");

            bool foundEqualCars = false;

            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        Console.WriteLine($"Car {i + 1} and Car {j + 1} are equal.");
                        foundEqualCars = true;
                    }
                }
            }

            if (!foundEqualCars)
            {
                Console.WriteLine("There are no equal cars.");
            }
        }
    }
}
