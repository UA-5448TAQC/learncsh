namespace ConsoleAppTasks.Models
{
    internal readonly struct Rgb
    {
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        public Rgb(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString()
        {
            return $"({Red}, {Green}, {Blue})";
        }
    }
}