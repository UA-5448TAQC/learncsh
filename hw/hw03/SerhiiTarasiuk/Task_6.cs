namespace ConsoleApp1
{
    internal class Task_6
    {
        static void Main(string[] args)
        {
           float number = ReadFloat("Enter a double number: ");

            int firstDigit = (int)(number * 10) % 10;
            int secondDigit = (int)(number * 100) % 10;
            
            Console.WriteLine($"The sum of the first two digits after the decimal point is: {firstDigit + secondDigit}");

            static float ReadFloat(string message)
            {
                while (true)
                {
                    Console.WriteLine(message);
                    string input = Console.ReadLine();

                    if (float.TryParse(input, out float result))
                        return result;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Only floating-point numbers are allowed.");
                    Console.ResetColor();
                }
            }
        }
    }
}
