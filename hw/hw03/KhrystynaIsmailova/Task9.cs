namespace Task9;
  struct RGB
{
    public byte red;
    public byte green;
    public byte blue;
}
internal class Program
    {
        static void Main(string[] args)
    {
        RGB white;
        white.red = 255;
        white.green = 255;
        white.blue = 255;

        RGB black;
        black.red = 0;
        black.green = 0;
        black.blue = 0;

        Console.WriteLine($"White: R={white.red}, G={white.green}, B={white.blue}");
        Console.WriteLine($"Black: R={black.red}, G={black.green}, B={black.blue}");
    }
}
