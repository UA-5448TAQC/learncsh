namespace ConsoleApp1
{
    internal class Task_6
    {
        static void Main(string[] args)
        {
            static string ReadName()
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("mmmm... Incognito. I'll call you 'Mystery Person'");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        return "Mystery Person";
                    }

                    if (input.Any(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No digits in name. Try again.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        continue; 
                    }

                    return input;
                }
            }
            static int ReadAge()
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int result) && result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ha ha ha.... Don't lie to me.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Enter your name:");
            string name = ReadName();

            Console.WriteLine("Enter your age:");
            int age = ReadAge();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\n Nice to meet you, {name}. You are {age} years old.");

        }
    }
}
