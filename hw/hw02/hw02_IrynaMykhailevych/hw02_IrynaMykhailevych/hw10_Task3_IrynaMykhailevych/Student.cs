using System;
using System.Collections.Generic;

namespace hw10_Task3_IrynaMykhailevych
{
    public delegate void MyDel(int m);
    public class Student
    {
        public string Name { get; set; }

        private List<int> marks;

        public event MyDel MarkChange;

        public Student(string name)
        {
            Name = name;
            marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            if (mark < 0 || mark > 12)
            {
                Console.WriteLine("Invalid mark. Please enter a value between 0 and 12.");
                return;
            }
            marks.Add(mark);
            MarkChange?.Invoke(mark);
        }
    }
}
