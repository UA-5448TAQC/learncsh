namespace Task1.5; // Overload operator ==

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
    }
    public Car(string CarName, string Color, double Price) //Конструктор з параметрами
    {
        this.CarName = CarName;
        this.Color = Color;
        this.Price = Price;
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
    public static bool operator ==(Car car1, Car car2)
    {
        return car1.CarName == car2.CarName &&
               car1.Price == car2.Price;
    }
    public static bool operator !=(Car a, Car b)
    {
        return !(a == b);
    }
}
internal class Program
{
    static void Main(string[] args)
    {


        Car car1 = new Car();
        Car car2 = new Car();

        Console.WriteLine("Enter data for car 1:");
        car1.Input();

        Console.WriteLine("Enter data for car 2:");
        car2.Input();


        Console.WriteLine("\nCars info:");

        car1.Print();
        car2.Print();

        Console.WriteLine("\nCompare cars:");
        Console.WriteLine(car1 == car2);

    }
}