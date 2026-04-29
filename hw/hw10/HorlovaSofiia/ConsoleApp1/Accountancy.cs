namespace ConsoleApp1
{
    internal class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 10)
            {
                Console.WriteLine("Student gets a scholarship.");
            }
            else
            {
                Console.WriteLine("Student does not get a scholarship.");
            }
        }
    }
}