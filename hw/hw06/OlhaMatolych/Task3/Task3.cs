
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<IDeveloper> developers = new List<IDeveloper>()
            {
                new Programmer("C#"),
                new Programmer("Python"),
                new Builder("Hammer"),
                new Builder("Drill")
            };

            Console.WriteLine("Before sorting:");
            foreach (var dev in developers)
            {
                dev.Create();
                dev.Destroy();
                Console.WriteLine();
            }
            developers.Sort(new DeveloperComparer());

            Console.WriteLine("After sorting:");
            foreach (var dev in developers)
            {
                dev.Create();
                dev.Destroy();
                Console.WriteLine();
            }
        }
    }
}