using System;

namespace HW06
{
    public class Plane : IFlyable
    {
        private string mark;
        private int highFly;

        public void Fly()
        {
            Console.WriteLine($"Plane {mark} can fly at {highFly} m.");

        }

        public Plane() { }
        public Plane(string m, int h)
        {
            mark = m;
            highFly = h;
        }
    }
}
