namespace hw5_Zoriana_Telychko
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Car_task1 car1 = new Car_task1();
            Car_task1 car2 = new Car_task1();
            Car_task1 car3 = new Car_task1();

            Car_task1[] cars = { car1, car2, car3 };
            foreach (Car_task1 car in cars)
            {
                car.Input();
                car.Print();

            }

            Console.WriteLine("\n\tAfter price change:");

            foreach (Car_task1 car in cars)
            {
                car.ChangePrice(-10);
                car.Print();

            }

            Console.WriteLine("Enter a new color ");
            string newColor = Console.ReadLine();


            bool anyRepainted = false;
            foreach (Car_task1 car in cars)
            {
                if (car.Color == "white" && newColor != null)
                {
                    car.Color = newColor;
                    car.Print();
                    anyRepainted = true;
                }
            }

            if (!anyRepainted) 
                Console.WriteLine("No white cars found. Nothing was repainted.");


            Console.WriteLine("\n--- Comparison ---");

            if (car1 == car2)
                Console.WriteLine($"Car1 vs Car2: identical\n  {car1}");
            else
                Console.WriteLine("Car1 vs Car2: different");

            if (car1 == car3)
                Console.WriteLine($"Car1 vs Car3: identical\n  {car1}");
            else
                Console.WriteLine("Car1 vs Car3: different");

            if (car2 == car3)
                Console.WriteLine($"Car2 vs Car3: identical\n  {car2}");
            else
                Console.WriteLine("Car2 vs Car3: different");
        }
    }
}
    


