namespace Task1.2; //Enter data about 3 cars

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
}
internal class Program
{
    static void Main(string[] args)
    {
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine("Enter data for car 1:");
            car1.Input();

            Console.WriteLine("Enter data for car 2:");
            car2.Input();

            Console.WriteLine("Enter data for car 3:");
            car3.Input();

            Console.WriteLine("\nCars info:");

            car1.Print();
            car2.Print();
            car3.Print();
        }
    }
}