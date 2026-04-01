namespace StructDog.Structs;

internal struct Dog(string name, string mark, int age)
{
    public string name = name;
    public string mark = mark;
    public int age = age;

    public override readonly string ToString()
    {
        return $"Name: {name}, Mark: {mark}, Age: {age}";
    }
}
