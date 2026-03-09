namespace HW_3
{
    internal class Task_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hour (0-23):");
            int hour;
            if (!int.TryParse(Console.ReadLine(), out hour))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (hour > 23 || hour < 0)
            {
                Console.WriteLine("Invalid hour.");
                return;
            }

            if (hour >= 6 && hour <= 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (hour >= 18 && hour <= 22)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }
        }
    }
}
