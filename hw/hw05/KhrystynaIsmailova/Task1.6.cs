namespace Task16; // Override ToString()

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

    public override string ToString() //ToString метод
    {
        return ($"Car {CarName} has {Color} color costs only {Price}$ in {CompanyName}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {


        Car car = new Car();

        Console.WriteLine("Enter data for car 1:");
        car.Input();


        Console.WriteLine("\nCar info:");


        Console.WriteLine(car);

    }
}