
namespace ConsoleApp1
{
    class Program
    {
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }
        static void Main()
        {
            RGB white;
            white.red = 255;
            white.green = 255;
            white.blue = 255;

            RGB black;
            black.red = 0;
            black.green = 0;
            black.blue = 0;

            Console.WriteLine("White color:");
            Console.WriteLine("Red: " + white.red);
            Console.WriteLine("Green: " + white.green);
            Console.WriteLine("Blue: " + white.blue);

            Console.WriteLine();

            Console.WriteLine("Black color:");
            Console.WriteLine("Red: " + black.red);
            Console.WriteLine("Green: " + black.green);
            Console.WriteLine("Blue: " + black.blue);
        }
    }
}