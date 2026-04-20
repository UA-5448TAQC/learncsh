using Task1ClassCar.Entities;

namespace Task1ClassCar;

internal class Program
{
    static void Main(string[] args)
    {
        Car car1 = new();
        Car car2 = new();
        Car car3 = new();

        Console.WriteLine("Enter data for Car 1:");
        car1.Input();

        Console.WriteLine("\nEnter data for Car 2:");
        car2.Input();

        Console.WriteLine("\nEnter data for Car 3:");
        car3.Input();

        Console.WriteLine("\nCars before price change:");
        car1.Print();
        car2.Print();
        car3.Print();

        car1.ChangePrice(-10);
        car2.ChangePrice(-10);
        car3.ChangePrice(-10);

        Console.WriteLine("\nCars after price change:");
        car1.Print();
        car2.Print();
        car3.Print();

        Console.Write("\nEnter new color for white cars: ");
        string newColor = Console.ReadLine() ?? "White";

        car1.Repaint(newColor);
        car2.Repaint(newColor);
        car3.Repaint(newColor);

        Console.WriteLine("\nCars after repaint:");
        car1.Print();
        car2.Print();
        car3.Print();

        Console.WriteLine("\nComparison:");
        Console.WriteLine(car1 == car2
            ? "Car 1 and Car 2 are equal."
            : "Car 1 and Car 2 are not equal.");
    }
}
