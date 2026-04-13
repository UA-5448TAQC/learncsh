using System;
namespace ConsoleAppVRHW06
{
    class Bird : IFlyable
    {
        public string name;
        public bool canFly;

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine($"{name} is flying!");
            }
            else
            {
                Console.WriteLine($"{name} cannot fly.");
            }
        }
    }

}
