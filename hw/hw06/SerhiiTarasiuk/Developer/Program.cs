namespace Developer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>()
            {
                new Programmer("C#"),
                new Programmer("Python"),
                new Builder("Hammer"),
                new Builder("Drill")
            };

            Console.WriteLine("Create and Destroy:");
            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine();
            }

            developers.Sort(delegate (IDeveloper first, IDeveloper second)
            {
                return first.Tool.CompareTo(second.Tool);
            });

            Console.WriteLine("Sorted developers:");
            foreach (IDeveloper developer in developers)
            {
                Console.WriteLine(developer.GetType().Name + " - " + developer.Tool);
            }
        }
    }
}
