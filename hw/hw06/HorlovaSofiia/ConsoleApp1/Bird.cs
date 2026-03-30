using System;
namespace ConsoleApp1
{
    internal class Bird : IFlyable
    {
        private readonly string name;
        private readonly bool canFly;

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine($"Bird {name} can fly.");
            }
            else
            {
                Console.WriteLine($"Bird {name} cannot fly.");
            }
        }

        public override string ToString()
        {
            return $"Bird: {name}, CanFly: {canFly}";
        }
    }
}