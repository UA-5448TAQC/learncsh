namespace ConsoleApp3
{
    public interface IDeveloper
    {
        string Tool { get; }
        void Create();
        void Destroy();
    }
    public class Programmer : IDeveloper, IComparable<Programmer>
    {
        private string language;
        public string Tool => language;
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine($"Programmer writes code in {language}.");
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer removes bugs from {language} code.");
        }
        public int CompareTo(Programmer other)
        {
            return Tool.CompareTo(other.Tool);
        }
    }
    public class Builder : IDeveloper, IComparable<Builder>
    {
        private string tool;
        public string Tool => tool;
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"Builder builds using {tool}.");
        }
        public void Destroy()
        {
            Console.WriteLine($"Builder destroys using {tool}.");
        }
        public int CompareTo(Builder other)
        {
            return Tool.CompareTo(other.Tool);
        }
    }
    public class DeveloperComparer : IComparer<IDeveloper>
    {
        public int Compare(IDeveloper x, IDeveloper y)
        {
            return x.Tool.CompareTo(y.Tool);
        }
    }
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
            Console.WriteLine("Before sorting:");
            foreach (var dev in developers)
            {
                Console.WriteLine(dev.Tool);
                dev.Create();
                dev.Destroy();
                Console.WriteLine();
            }
            developers.Sort(new DeveloperComparer());
            Console.WriteLine("After sorting:");
            foreach (var dev in developers)
            {
                Console.WriteLine(dev.Tool);
                dev.Create();
                dev.Destroy();
                Console.WriteLine();
            }

        }
    }
}



