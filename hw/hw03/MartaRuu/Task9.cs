using System.Transactions;

namespace ConsoleApp3
{
    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;

        public override string ToString() => $"(R={red}, G={green}, B={blue})";

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Task 9");
                RGB white = new RGB { red = 255, green = 255, blue = 255 };
                RGB black = new RGB { red = 0, green = 0, blue = 0 };
                Console.WriteLine($"White {white}");
                Console.WriteLine($"Black {black}");
            }
        }
    }
}
