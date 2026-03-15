using System.Drawing;

namespace hw05_IrynaMykhailevych
{
    internal class ProgramCar
    {
        public static void Main()
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Car[] cars = { car1, car2, car3 };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("---------------");
                Console.WriteLine($"Enter data for car {i + 1}:");
                cars[i].Input();
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Initial data: ");
            car1.Print();
            car2.Print();
            car3.Print();
            Console.WriteLine();

            car1.ChangePrice(-10);
            car2.ChangePrice(-10);
            car3.ChangePrice(-10);

            Console.WriteLine("After price change: ");
            car1.Print();
            car2.Print();
            car3.Print();
            Console.WriteLine();

            Console.WriteLine("Enter a new color: ");
            string newColor = Console.ReadLine();

            foreach (Car car in cars)
            {
                if (car.Color.ToLower() == "white")
                {
                    car.Color = newColor;
                }
            }

            Console.WriteLine("After repaint: ");
            car1.Print();
            car2.Print();
            car3.Print();
            Console.WriteLine();
        }
    }
}
