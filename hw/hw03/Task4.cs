using System.Net.Cache;

namespace Task4;
struct Dog
{
    public string Name;
    public string Mark;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine("Name: {0}, Mark: {1}, Age: {2}", Name, Mark, Age);
    }
}
class Program
{
    static void Main(string[] args)
        {
        Dog Dog1;
        Dog1.Name = "Billy";
        Dog1.Mark = "dvordog";
        Dog1.Age = 11;

        Dog1.DisplayInfo();
        
        }
}

