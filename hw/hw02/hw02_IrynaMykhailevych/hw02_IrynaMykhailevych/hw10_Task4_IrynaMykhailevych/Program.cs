using System;
using System.Text.Json;
using System.IO;

namespace hw10_Task4_IrynaMykhailevych
{
    internal class Program
    {
        static void Run()
        {
            Car car = new Car("BMW X5", "Black", 50000);

            string json = JsonSerializer.Serialize(car);

            Console.WriteLine(json);

            File.WriteAllText("car.json", json);

            string jsonFromFile = File.ReadAllText("car.json");

            Car carFromFile = JsonSerializer.Deserialize<Car>(jsonFromFile);

            Console.WriteLine(carFromFile.Name);
            Console.WriteLine(carFromFile.Color);
            Console.WriteLine(carFromFile.Price);
        }
    }
}
