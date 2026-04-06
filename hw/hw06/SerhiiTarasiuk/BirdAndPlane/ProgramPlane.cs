namespace ConsoleApp1
{
    internal class ProgramPlane
    {
        static void Main(string[] args)
        {
            List<IFlyable> items = new List<IFlyable>()
            {
                new Bird("Eagle", true),
                new Bird("Penguin", false),
                new Plane("Boeing", 10000)
            };

            foreach (IFlyable item in items)
            {
                item.Fly();
            }
        }
    }
}
