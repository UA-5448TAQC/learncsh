namespace GreetingByHour;

internal class Program
{
    static void Main(string[] args)
    {
        int hour = ReadHour();

        if (hour >= 6 && hour < 12)
        {
            Console.WriteLine("Good morning!");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good afternoon!");
        }
        else if (hour >= 18 && hour < 23)
        {
            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("Good night!");
        }
    }

    private static int ReadHour()
    {
        do
        {
            Console.WriteLine("Enter the current hour (0-23):");

            if (int.TryParse(Console.ReadLine(), out int hour) || hour < 0 || hour > 23)
            {
                return hour;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }
        while (true);
    }
}
