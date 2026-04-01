namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hour: ");
            int h = int.Parse (Console.ReadLine());
            ////if 
            ////    {
            //h >= 0 ||
            //h <= 5 ||
            //h >= 23 ||
            //h <= 24;
            //    Console.WriteLine("Goog night!");            
            //    //}
            if (h < 0 || h > 23)
            {
                Console.WriteLine("Invalid hour.");
                return;   // зупиняємо програму
            }
            else if (h >= 23 || h <= 5)
            {
                Console.WriteLine("Good night!");
            }
            else if (h >= 22 || h <= 18)
            {
                Console.WriteLine("Good evening!");
            }
            else if (h >= 17 || h <= 12)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (h >= 11 || h <= 6)
            {
                Console.WriteLine("Good morning!");
            }

        }
    }
}
