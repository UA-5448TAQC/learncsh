namespace HW_3
{
    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;

        public void DisplayInfo()
        {
            Console.WriteLine($"({red}, {green}, {blue})");
        }
    }
    internal class Task_9
    {
        static void Main(string[] args)
        {
            RGB white, black;
            white.red = 255;
            white.green = 255;
            white.blue = 255;

            black.red = 0;
            black.green = 0;
            black.blue = 0;

            white.DisplayInfo();
            black.DisplayInfo();
        }
    }
}