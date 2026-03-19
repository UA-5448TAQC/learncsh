using System.Drawing;

namespace Task1.1; //Define class Car

public class Car
{
    public string CarName;
    private string color;
    public double Price;
    public const string CompanyName = "AudiOfficial";

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public Car() //Дефолтний конструктор
    {
        CarName = "Audi";
        Color = "white";
        Price = 15000;
        //CompanyName = "AudiOfficial"; 
    }
    public Car(string CarName, string Color, double Price) //Конструктор з параметрами
    {
        this.CarName = CarName;
        this.Color = Color;
        this.Price = Price;
        //this.CompanyName = CompanyName;
    }
    public void Input() //Input метод
    {
        Console.WriteLine("Enter car name: ");
        CarName = Console.ReadLine();

        Console.WriteLine("Enter car color: ");
        Color = Console.ReadLine();

        Console.WriteLine("Enter price: ");
        Price = Convert.ToDouble(Console.ReadLine());
    }
    public void Print() //Прінт метод
    {
        Console.WriteLine($"Car {CarName} has {Color} color costs only {Price}$ in {CompanyName}");
    }
    public void ChangePrice(double x) //Change price method
    {
        Price = Price + (Price * x / 100);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Car car = new Car();

                car.Input();      // вводимо дані
                car.Print();      // виводимо

                car.ChangePrice(10); // +10%
                car.Print();         // перевірка
            }
            //Car car1 = new Car("BMW", "black", 20000, "BMW Corporate");
            //Console.WriteLine($"Car {car1.CarName} has {car1.Color} color costs only {car1.Price}$ in {car1.CompanyName}");
        }
    }
}