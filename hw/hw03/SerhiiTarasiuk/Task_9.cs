
namespace ConsoleApp1
{
    internal class Task_9
    {
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }
        static void PrintColor(string name, RGB color)
        {
            Console.Write($"{name}: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"R={color.red} ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"G={color.green} ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"B={color.blue}");

            Console.ResetColor();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            RGB white = new RGB 
            {
                red = 255,
                green = 255,
                blue = 255 
             };

            RGB black = new RGB 
            {
                red = 0,
                green = 0,
                blue = 0 
             };

            PrintColor("White", white);
            PrintColor("Black", black);
        }
    }
}
