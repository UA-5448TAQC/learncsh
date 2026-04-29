namespace ConsoleApp1
{
    public delegate void MyDel(int m);

    internal class Student
    {
        private readonly List<int> marks;

        public string Name { get; set; }

        public event MyDel? MarkChange;

        public Student(string name)
        {
            Name = name;
            marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            marks.Add(mark);
            MarkChange?.Invoke(mark);
        }
    }
}