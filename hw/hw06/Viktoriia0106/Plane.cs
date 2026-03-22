using System;
namespace ConsoleAppVRHW06
{
    class Plane : IFlyable
    {
        public string mark;
        public int highFly;
        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"{mark} is flying at an altitude of {highFly} feet");
        }
    }
}