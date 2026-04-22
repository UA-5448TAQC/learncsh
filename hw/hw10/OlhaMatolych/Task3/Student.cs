using System.Collections.Generic;

namespace Task3;

public delegate void MyDel(int m);

internal class Student
{
    public string Name { get; set; }
    public List<int> Marks { get; set; } = new();

    public event MyDel MarkChange;

    public void AddMark(int mark)
    {
        Marks.Add(mark);
        MarkChange?.Invoke(mark);
    }
}