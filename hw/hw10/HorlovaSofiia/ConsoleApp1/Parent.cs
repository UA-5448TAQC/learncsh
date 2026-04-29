namespace ConsoleApp1
{
    internal class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"Parent received new mark: {mark}");
        }
    }
}