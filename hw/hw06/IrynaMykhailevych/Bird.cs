using System;

namespace hw06_Task1_IrynaMykhailevych
{
    internal class Bird : IFlyable
    {
        public string Name { get; set; } = "";
        public bool CanFly { get; set; }

        public void Fly()
        {
            if (CanFly)
            {
                Console.WriteLine($"Bird {Name} is flying.");
            }
            else
            {
                Console.WriteLine($"Bird {Name} cannot fly.");
            }
        }
    }
}
