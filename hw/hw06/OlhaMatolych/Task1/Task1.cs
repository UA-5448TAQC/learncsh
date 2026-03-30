
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<IFlyable> list = new List<IFlyable>()
            { new Bird("Eagle", true),
              new Bird("Penguin", false),
              new Plane("Boeing", 10000),
              new Plane("Antonov", 8000)
            };
            foreach (var item in list)
            {
                item.Fly();
            }
        }
    }
}