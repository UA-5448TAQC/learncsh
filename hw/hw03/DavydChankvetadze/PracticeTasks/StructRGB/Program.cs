using StructRGB.Structs;

namespace StructRGB;

internal class Program
{
    static void Main(string[] args)
    {
        RGB whiteColor = new(255, 255, 255);
        RGB blackColor = new(0, 0, 0);

        Console.WriteLine(whiteColor);
        Console.WriteLine(blackColor);
    }
}
