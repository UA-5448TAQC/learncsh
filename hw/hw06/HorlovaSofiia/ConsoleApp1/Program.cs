using System.Buffers.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task61.Run();
            Task62.Run();
            Task63.Run();
            Task64.Run();

            Console.WriteLine();
            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }
    }
}