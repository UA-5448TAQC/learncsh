namespace ConsoleApp1
{
    public class Plane : IFlyable
    {
        private string mark;
        private int highFly;

        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Plane {mark} flies at {highFly} meters.");
        }
    }
}
