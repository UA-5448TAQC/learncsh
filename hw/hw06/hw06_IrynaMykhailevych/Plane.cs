using System;

namespace hw06_Task1_IrynaMykhailevych
{
    internal class Plane : IFlyable
    {
        public string Mark { get; set; } = "";
        public int HighFly { get; set; }

        public void Fly()
        {
            Console.WriteLine($"Plane {Mark} is flying at {HighFly} meters.");
        }
    }
}
