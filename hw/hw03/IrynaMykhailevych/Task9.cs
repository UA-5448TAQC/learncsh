using System;

namespace hw03_IrynaMykhailevych
{
    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
        public override string ToString()
        {
            return $"RGB({red}, {green}, {blue})";
        }
    }
    internal class Task9
    {
        public static void Run()
        {
            RGB white = new RGB { red = 255, green = 255, blue = 255 };
            RGB black = new RGB { red = 0, green = 0, blue = 0 };

            Console.WriteLine($"White color: {white}");
            Console.WriteLine($"Black color: {black}");
        }
    }
}
