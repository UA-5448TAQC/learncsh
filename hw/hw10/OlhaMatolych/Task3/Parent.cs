using System;

namespace Task3;

internal class Parent
{
    public void OnMarkChange(int mark)
    {
        Console.WriteLine($"Parent: new mark {mark}");
    }
}