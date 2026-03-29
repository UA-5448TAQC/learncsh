
namespace ConsoleApp1
{
    internal class Bird(string name, bool canFly) : IFlyable
    {
        public string Name { get; set; } = name;
        public bool CanFly { get; set; } = canFly;

        public void Fly()
        {
            if (CanFly)
                Console.WriteLine($"Bird: {Name} can fly.");
            else
                Console.WriteLine($"Bird: {Name} cannot fly.");
        }
    }
}