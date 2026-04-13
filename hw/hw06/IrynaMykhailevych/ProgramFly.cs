using System;

namespace hw06_Task1_IrynaMykhailevych
{
    internal class ProgramFly
    {
        public static void Main()
        {
            Bird bird1 = new Bird() { Name = "Sparrow", CanFly = true };
            Bird bird2 = new Bird() { Name = "Penguin", CanFly = false };
            Bird bird3 = new Bird() { Name = "Eagle", CanFly = true };
            Plane plane1 = new Plane() { Mark = "Boeing 747", HighFly = 35000 };
            Plane plane2 = new Plane() { Mark = "Airbus A380", HighFly = 40000 };
            Plane plane3 = new Plane() { Mark = "Cessna 172", HighFly = 13000 };

            List<IFlyable> flyables = new List<IFlyable>();

            flyables.Add(bird1);
            flyables.Add(bird2);
            flyables.Add(bird3);
            flyables.Add(plane1);
            flyables.Add(plane2);
            flyables.Add(plane3);

            foreach (var item in flyables)
            {
                item.Fly();
            }
        }
    }   
}
