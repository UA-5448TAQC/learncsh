namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            cars[0] = new Car();
            cars[1] = new Car();
            cars[2] = new Car();

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"\nEnter data for car #{i + 1}");
                cars[i].Input();
            }

            Console.WriteLine("\nInitial car information:");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Print();
            }

            Console.WriteLine("\nDecreasing price by 10%...");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(-10);
            }

            Console.WriteLine("Updated car information: ");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Print();
            }

            Console.WriteLine("\nEnter a new color to repaint white cars:");
            string newColor = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color == "white")
                {
                    cars[i].Color = newColor;
                }

            }


            Console.WriteLine("\nChecking whether your cars are equal...");
            if (cars[0] == cars[1] && cars[0] == cars[2])
            {
                Console.WriteLine("\nAll cars are equal.");
            }
            else
            {
                Console.WriteLine("\nAll cars are NOT equal");
            }

            Console.WriteLine("\nFinal car information:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
        }
    }
}
