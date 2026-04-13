using System;
namespace ConsoleApp1
{
    internal class Plane : IFlyable
    {
        private readonly string mark;
        private readonly int highFly;

        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Plane {mark} flies at {highFly} meters.");
        }

        public override string ToString()
        {
            return $"Plane: {mark}, HighFly: {highFly}";
        }
    }
}