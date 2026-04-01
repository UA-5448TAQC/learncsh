namespace StructRGB.Structs;

internal struct RGB(byte r, byte g, byte b)
{
    public byte R = r;
    public byte G = g;
    public byte B = b;

    public override readonly string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}
