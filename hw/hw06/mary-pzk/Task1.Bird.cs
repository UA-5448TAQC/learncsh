using System;

namespace HW06
{
    public class Bird : IFlyable
    {
        private string name;
        private bool canFly;

        public void Fly()
        {
            Console.WriteLine(canFly
                ? $"Bird {name} is flying."
                : $"Bird {name} cannot fly.");
        }

        public Bird() { }
        public Bird(string n, bool c)
        {
            name = n;
            canFly = c;
        }
    }
}
