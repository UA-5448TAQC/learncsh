namespace Helpers
{
    internal class ProgramHelpers
    {

        public static int ReadPositiveInt(string input)
        {
            int result;
            while (true)
            {
                Console.WriteLine(input);
                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                    Console.ResetColor();
                }
            }
        }

        public static string ReadNonEmptyString(string input)
        {
            while (true)
            {
                Console.WriteLine(input);
                string result = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input cannot be empty. Please enter a valid string.");
                    Console.ResetColor();
                }
            }
        }
    }
}