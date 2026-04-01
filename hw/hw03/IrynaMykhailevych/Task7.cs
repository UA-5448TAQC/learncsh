using System;

namespace hw03_IrynaMykhailevych
{
    internal class Task7
    {
        public static void Run()
        {
            int hour = ReadInt("Enter hour (0-23): ");

            if (!IsValidHour(hour))
            {
                Console.WriteLine("Invalid hour.");
                return;
            }

            string greeting = GetGreeting(hour);

            Console.WriteLine(greeting);
        }
        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter the valid value: ");
                input = Console.ReadLine();
            }
            return result;
        }
        static bool IsValidHour(int hour)
        {
                return hour >= 0 && hour <= 23;
        }
        static string GetGreeting(int hour)
        {
            if (hour >= 6 && hour <= 11)
                return "Good morning!";
            if (hour >=12 && hour <= 17)
                return "Good afternoon!";
            if (hour >= 18 && hour <= 22)
                return "Good evening!";
            return "Good night!";
        }
    }
}
